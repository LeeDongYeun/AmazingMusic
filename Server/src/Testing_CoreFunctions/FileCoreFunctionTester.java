package Testing_CoreFunctions;

import java.io.File;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Random;


import Object.LinkedList;
import Object.FileInfo;
import API.FileCoreFunctions;
import SQLpackage.Database;

public class FileCoreFunctionTester {
	
	public static void main(String[] args) throws SQLException {
		LinkedList list = new LinkedList();
		FileInfo flInfo = null;
		
		flInfo = fileInfoGenerator();
		list = linkedListGenerator(flInfo);
		verification(uploadTest(list));
		
		flInfo = fileInfoGenerator();
		list = linkedListGenerator(flInfo);
		verification(uploadTest(list));
		
		flInfo = fileInfoGenerator();
		list = linkedListGenerator(flInfo);
		verification(uploadTest(list));
		
		flInfo = fileInfoGenerator();
		list = linkedListGenerator(flInfo);
		verification(uploadTest(list));
		
		
		flInfo = fileInfoGenerator();
		verification(validateTest(flInfo));
		
	}
	
	private static boolean validateTest(FileInfo flInfo) throws SQLException {
		Database db = null;
		ResultSet rs = null;
		
		String path = "temporary" + File.separatorChar + flInfo.getFileSerial() +flInfo.getExension();
		String output = FileCoreFunctions.validate(flInfo);
		File music = new File(path);
		
		if(output =="") {
			System.out.println("Exception occured in validate function");
			return false;
		}
		else if(output == "VALIDATE FAIL") {
			System.out.println("Case : VALIDATE FAIL");
			db = new Database();
			rs = db.readDB("select MD5 from `amazingmusicdb`.`waitingfile` where MD5='" + flInfo.getMD5() + "'");
			
			if(!rs.next()) {
				System.out.println("Waiting file DB clear");
				
				if(!music.exists()) {
					System.out.println("File has been removed clearly");
					return true;
				}
				else {
					System.out.println("File is still there");
					return false;
				}
			}
			else {
				System.out.println("Waiting file DB is not clear");
				return false;
			}
		}
		else if(output == "VALIDATE SUCCESS") {
			System.out.println("Case : VALIDATE SUCCESS");
			db = new Database();
			rs = db.readDB("select MD5 from `amazingmusicdb`.`waitingfile` where MD5='" + flInfo.getMD5() + "'");
			
			if(!rs.next()) {
				System.out.println("Waiting file DB clear");
				rs = db.readDB("select fileSerial from `amazingmusicdb`.`postfile` where fileSerial='" + flInfo.getFileSerial() + "'");
				
				if(rs.next()) {
					System.out.println("There is a file DB in the post file DB");
					
					if(!music.exists()) {
						System.out.println("File has been removed clearly");
						music = new File(flInfo.getUID() + File.separatorChar + flInfo.getFileSerial() + flInfo.getExension());
						
						if(music.exists()) {
							System.out.println("File has been moved to new path");
							return true;
						}
						
						else {
							System.out.println("File has not been moved to new path");
							return false;
						}
					}
					
					else {
						System.out.println("File is still there");
						return false;
					}
				}
				
				else {
					System.out.println("There is no file DB in the post file DB");
					return false;
				}
			}
			
			else {
				System.out.println("Waiting file DB is not clear");
				return false;
			}
		}
		else {
			System.out.println("Not matching output of function validate");
			return false;
		}
	}
	
	private static boolean uploadTest(LinkedList ll) {
		FileInfo flInfo = (FileInfo) ll.end.getInfo();
		
		LinkedList result = FileCoreFunctions.upload(ll);
		if(result.head.getInfo() == "OK") {
			System.out.println("the head of LinkedList is OK");
			FileInfo resultFlInfo = (FileInfo) result.end.getInfo();
			if(resultFlInfo.getUID() == flInfo.getUID())
					if(resultFlInfo.getOriName() == flInfo.getOriName())
							if(resultFlInfo.getMD5() == flInfo.getMD5())
									if(resultFlInfo.getFileSerial() == flInfo.getFileSerial())
											if(resultFlInfo.getExension() == flInfo.getExension()) {
													System.out.println("the FileInfo is same");
													return true;
											}
			
		}
	
		System.out.println("test failed");
		return false;
	}
	
	private static LinkedList linkedListGenerator(FileInfo flInfo) {
		LinkedList ll = new LinkedList();
		
		ll.add(flInfo);
		
		return ll;
	}
	
	private static FileInfo fileInfoGenerator() {
		Random rng = new Random();
		String uid = generateString(rng,"abcdefghijklmnopqrstuvwxyz", 10);
		String oriName = generateString(rng,"abcdefghijklmnopqrstuvwxyz", 29) + ".wav";
		String md5 = generateString(rng,"abcdefghijklmnopqrstuvwxyz", 32);
		String ext = ".wav";
		
		FileInfo flInfo = new FileInfo(uid, oriName, md5, ext);
		
		return flInfo;
	}
	
	public static String generateString(Random rng, String characters, int length)
	{
	    char[] text = new char[length];
	    for (int i = 0; i < length; i++)
	    {
	        text[i] = characters.charAt(rng.nextInt(characters.length()));
	    }
	    return new String(text);
	}
	
	private static void verification(boolean statement) {
		if (statement) {
			System.out.println("TEST SUCCESS");
		} 
		else {
			System.out.println("TEST FAIL");
		}
	}
	
	

}
