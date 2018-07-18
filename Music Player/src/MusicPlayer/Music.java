/**
 * This is a open sources code, I have changed something inside in order to meet the requirement of our project
 * Source: https://www.cnblogs.com/xiaolai/p/3189672.html
 * Author: laijiawei
 */
package MusicPlayer;

public class Music {
	
	private String id;
	private String name;
	private String path;
	
	public Music (String i, String n, String p) {
		this.id = i;
		this.name = n;
		this.path = p;
	}
	
	public String getId() {
		return id;
	}
	public String getName() {
		return name;
	}
	public String getPath() {
		return path;
	}
}
