package Testing_CoreFunctions;

import java.util.Random;


import Object.LinkedList;
import Object.FileInfo;
import API.FileCoreFunctions;

public class FileCoreFunctionTester {
	
	public static void main(String[] args) {
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
