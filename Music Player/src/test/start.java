package test;

import MusicPlayer.*;

public class start {

	private static Player audio_player;
	
	public static void main(String[] args) {
		audio_player = new Player();
		
<<<<<<< HEAD
		Music music = new Music("test", "F:\\Yamaha-V50-Metalimba-C2.wav");
=======
		String add = "C:\\Users\\yguo3\\Downloads\\Roland-JV-2080-PizzicatoStr-C5.wav";
		Music music = new Music("test", add);
>>>>>>> 297520ce6e5800d0caa01f02eade84ab9d786d17
		
		audio_player.setMusic(music);
		audio_player.start();
		
		System.out.println("start playing");
		
		try {
			Thread.sleep(3000);
			
			audio_player.PausePlayer();
			Thread.sleep(1000);
			audio_player.ResumePlayer();
			Thread.sleep(2000);
			
			
			audio_player.SeekPlayer(60 * 1000);
			Thread.sleep(2000);
			
			audio_player.SeekPlayer(120 * 1000);
			Thread.sleep(2000);
			
			audio_player.SeekPlayer(180 * 1000);
			Thread.sleep(2000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		audio_player.StopPlayer();
		
		System.out.println("stop playing");
	}
}
