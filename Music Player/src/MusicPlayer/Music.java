/**
 * This is a open sources code, I have changed something inside in order to meet the requirement of our project
 * Source: https://www.cnblogs.com/xiaolai/p/3189672.html
 * Author: laijiawei
 */
package MusicPlayer;

public class Music {
	
	private String name;
	private String path;
	
	public Music (String n, String p) {
		this.name = n;
		this.path = p;
	}
	
	public String getName() {
		return name;
	}
	
	public String getPath() {
		return path;
	}
}
