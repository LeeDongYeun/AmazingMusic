package com.service;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import javax.sound.sampled.*;
import com.service.Music;
import org.apache.commons.io.FileUtils;

public class Player extends Thread {
	// 构造函数
	public Player() {
		super();
	}
	//初始化文件的总时间，单位毫秒？
	private long duration = 0;
	
	// 同步暂停变量
	Object lock = new Object();

	private boolean paused = false;
	// 显示是否为暂停状态
	public boolean isPaused() {
		return paused;
	}
	//初始化控制停止播放？
	private boolean over = false;
	//初始化seek操作，传入要拖动到的时间点。ui上进度条拖拽
	private long seektime = -1;
	// 初始化java播放音频的对象
	SourceDataLine line = null;
	// 初始化声音控制
	private FloatControl volume = null;
	// 初始化音频文件
	private Music music;
	// 获取音频对象
	public void setMusic(Music music) {
		this.music = music;
	}
    //表示音量，用户传入的vol保存到自己的变量
	public FloatControl getVolume() {
		return volume;
	}
	// 获取文件播放总时间
	public long getDuration() {
		return duration;
	}

	public void run() {
		//设置一个新的音频文件导入
		AudioInputStream in = null;
		try {
			System.out.println("music path " + music.getPath());
			// File file = new File(music.getPath());
			// File file = new File("http://10.3.80.185/44.wav");

			File file = null;
			// remote file
			if (music.getPath().substring(0, 3).equals("http")) {
				URL url = new URL(music.getPath());
				String tDir = System.getProperty("java.io.tmpdir");
				String path = tDir + "tmp" + ".wav";
				file = new File(path);
				file.deleteOnExit();
				FileUtils.copyURLToFile(url, file);
			}
			// local file
			else {
				file = new File(music.getPath());
			}

			try {
				in = AudioSystem.getAudioInputStream(file);
			//得到一个音乐输入对象
			} catch (Exception e) {
				System.out.println(music.getId() + "music id " + music.getPath());
				return;
			}
			//读取wav文件的PCM编码，采样率信息，采样精度信息，声道信息，然后把这些信息输给播放器
			AudioFormat baseFormat = in.getFormat();
			AudioFormat decodedFormat = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, baseFormat.getSampleRate(), 16,
					baseFormat.getChannels(), baseFormat.getChannels() * 2, baseFormat.getSampleRate(), false);
			
			if (baseFormat.getEncoding() == AudioFormat.Encoding.PCM_UNSIGNED
					|| baseFormat.getEncoding() == AudioFormat.Encoding.ULAW
					|| baseFormat.getEncoding() == AudioFormat.Encoding.ALAW
					|| baseFormat.getEncoding() == AudioFormat.Encoding.PCM_SIGNED) {
				duration = (file.length() * 1000) / ((int) (decodedFormat.getSampleRate() * baseFormat.getFrameSize()));
				
				System.out.println("duration1 " + duration + " ms");
			} else {
				int bitrate = 0;
				if (baseFormat.properties().get("bitrate") != null) {
					bitrate = (int) ((Integer) (baseFormat.properties().get("bitrate")));
					if (bitrate != 0)
						duration = (file.length() * 8000) / bitrate;
					System.out.println("duration2 " + duration);
				}
			}
			//line用来承载decode之后的数组，用于播放声音
			DataLine.Info info = new DataLine.Info(SourceDataLine.class, decodedFormat);
			line = (SourceDataLine) AudioSystem.getLine(info);
			line.open();
			setVolume(0.8f);

			if (line != null) {
				line.open(decodedFormat);
				//读取音频文件数据
				byte[] data = new byte[4096];
				int nBytesRead;
				//处理暂停情况
				synchronized (lock) {
					//不停地从文件里读数据
					while ((nBytesRead = in.read(data, 0, data.length)) != -1) {
						while (paused) {
							if (line.isRunning()) {
								line.stop();
								System.out.println("paused");
							}
							try {
								lock.wait();
								System.out.println("waited");
							} catch (InterruptedException e) {
							}
						}
						if (!line.isRunning() && !over) {
							line.start();
						}

						if (over && line.isRunning()) {
							line.drain();
							line.stop();
							line.close();
						}

						line.write(data, 0, nBytesRead);
						//用户拖动进度条时，seek处理的代码
						//seek时，销毁原来的java读文件对象，重新创建一个读文件对象，并且直接从seek时间点开始读文件
						if (seektime != -1) {
							in.close();
							in = AudioSystem.getAudioInputStream(file);
							if (duration > 0) {
								in.skip(file.length() * seektime / duration);	
							}

							System.out.println("seeked to " + seektime);
							seektime = -1;
						}
					}
					System.out.println("stop playing");
				}

			}

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (in != null) {
				try {
					in.close();
				} catch (IOException e) {
				}
			}
		}
	}
	//停止播放UI
	public void StopPlayer() {
		over = true;
	}
	//暂停UI
	public void PausePlayer() {
		if (paused) {
			synchronized (lock) {
				paused = false;
				lock.notifyAll();
			}
		} else {
			paused = true;
		}
	}
	//复播UI
	public void ResumePlayer() {
		synchronized (lock) {
			paused = false;
			lock.notifyAll();
		}
	}

	//拖动按钮UI
	public void SeekPlayer(long time) {
		if (time < 0 || time > duration) {
			throw new IllegalArgumentException("seek time not valid: " + time);
		}
		seektime = time;
	}
	
	//把用户传入的vol保存或控制自己的变量（变音量UI），范围是0.0到1.0，0.0是静音
	public void setVolume(float vol) {
		if (line != null) {
			if (line.isControlSupported(FloatControl.Type.MASTER_GAIN)) {
				if (vol < 0f || vol > 1f)
			        throw new IllegalArgumentException("Volume not valid: " + vol);
				
				volume = (FloatControl) line.getControl(FloatControl.Type.MASTER_GAIN);
				volume.setValue(20f * (float) Math.log10(vol));
			}
			System.out.println("set volume " + vol);
		} else {
			volume = null;
			System.out.println("set volume failed");
		}
	}
}
