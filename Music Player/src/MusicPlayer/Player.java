/**
 * This is a open sources code, I have changed something inside in order to meet the requirement of our project
 * Source: https://www.cnblogs.com/xiaolai/p/3189672.html
 * Author: laijiawei
 */
package MusicPlayer;

import java.io.File;
import java.io.IOException;
import javax.sound.sampled.*;
import MusicPlayer.Music;

public class Player extends Thread {
	// make a constructor
	public Player() {
		super();
	}
	//Initialize the total time for a file
	private long duration = 0;
	
	//Synchronization pause variable
	Object lock = new Object();

	private boolean paused = false;
	// Show the paused status
	public boolean isPaused() {
		return paused;
	}
	//Initialize stop playing
	private boolean over = false;
	//Initialize the seek operation
	private long seektime = -1;
	// Initialize the object that java plays audio
	SourceDataLine line = null;
	//Initialize sound control
	private FloatControl volume = null;
	// Initialize the audio file
	private Music music;
	// Get audio object
	public void setMusic(Music music) {
		this.music = music;
	}
    //Indicates the volume, let the user-transferred vol be saved as own variable
	public FloatControl getVolume() {
		return volume;
	}
	// Get the total time of file playing
	public long getDuration() {
		return duration;
	}

	public void run() {
		//Set up a new audio file to import
		AudioInputStream in = null;
		try {
			System.out.println("music path " + music.getPath());
			// File file = new File(music.getPath());
			// File file = new File("http://10.3.80.185/44.wav");

			File file = null;
			
			file = new File(music.getPath());
			

			try {
				in = AudioSystem.getAudioInputStream(file);
			//Get a music input object
			} catch (Exception e) {
				System.out.println(music.getId() + "music id " + music.getPath());
				return;
			}
			//Read the PCM code of the wav file, sample rate information, sampling accuracy information, channel information, and then input the information to the player
			AudioFormat baseFormat = in.getFormat();
			AudioFormat decodedFormat = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, baseFormat.getSampleRate(), 16,
					baseFormat.getChannels(), baseFormat.getChannels() * 2, baseFormat.getSampleRate(), false);
			
			if (baseFormat.getEncoding() == AudioFormat.Encoding.PCM_UNSIGNED
					|| baseFormat.getEncoding() == AudioFormat.Encoding.ULAW
					|| baseFormat.getEncoding() == AudioFormat.Encoding.ALAW
					|| baseFormat.getEncoding() == AudioFormat.Encoding.PCM_SIGNED) {
				duration = (file.length() * 1000) / ((int) (decodedFormat.getSampleRate() * baseFormat.getFrameSize()));
				
				System.out.println("duration1 " + duration + " ms");
			// This is used to read other kinds of files such as mp3 file. (Backup)
			} else {
				int bitrate = 0;
				if (baseFormat.properties().get("bitrate") != null) {
					bitrate = (int) ((Integer) (baseFormat.properties().get("bitrate")));
					if (bitrate != 0)
						duration = (file.length() * 8000) / bitrate;
					System.out.println("duration2 " + duration);
				}
			}
			//Line is used to carry an array after decode, used to play sound
			DataLine.Info info = new DataLine.Info(SourceDataLine.class, decodedFormat);
			line = (SourceDataLine) AudioSystem.getLine(info);
			line.open();
			setVolume(0.8f);

			if (line != null) {
				line.open(decodedFormat);
				//Read audio file data
				byte[] data = new byte[4096];
				int nBytesRead;
				//Handling pauses status
				synchronized (lock) {
					//Keep reading data from files
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
						//The code processed by seek when the user drags the progress bar
						//When seeking, destroy the original java read file object, re-create a read file object, and open directly from the seek time始读文件
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
	//The UI for stop playing
	public void StopPlayer() {
		over = true;
	}
	//The UI for pause
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
	//The UI for resume
	public void ResumePlayer() {
		synchronized (lock) {
			paused = false;
			lock.notifyAll();
		}
	}

	//The UI for seeking button
	public void SeekPlayer(long time) {
		if (time < 0 || time > duration) {
			throw new IllegalArgumentException("seek time not valid: " + time);
		}
		seektime = time;
	}
	
	//volume control UI, the range is 0.0-1.0
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
