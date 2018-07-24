package Testing_CoreFunctions;

import java.io.IOException;
import java.math.BigInteger;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Random;

import Client.SocketClient;
import Object.FileInfo;
import Object.LinkedList;
import Object.User;

public class TesterClient {
	
	public static void main(String[] args) throws Exception {
		
		/**
		 * Purpose: Test CoreFunctions.java and Decoder.java mainly.
		 * 			Test (1) client send a random linkedlist request, 
		 * 				 (2) server receive the request, 
		 * 				 (3) verify that the server receive the linkedlist accurately.
		 * Input requirement: None
		 * Output: None
		 */
		
		LinkedList list;
		User user;
		
		/*
		 * Test:
		 * 1. Validity of registration function.
		 * 2. User is not registered yet.
		 * 3. Wrong password.
		 * 4. Registered user.
		 * 5. Upload request in GPS-side (not file server side)
		 */
		
		list = new LinkedList();
		list.add("reg");
		user = new User("icho@ucsc.edu", "cofls8680*");
		list.add(user);
		String request = (String) SocketClient.request(list);
		verification(request.equals("REG:USEREXISTS") || request.equals("UPS"));
		
		list = new LinkedList();
		list.add("lgn");
		user = new User("ich@ucsc.edu", "cofls8680*");
		list.add(user);
		verification(((String) SocketClient.request(list)).equals("LOGIN:NOTREG"));
		
		list = new LinkedList();
		list.add("lgn");
		user = new User("icho@ucsc.edu", "cofls8680");
		list.add(user);
		verification(((String) SocketClient.request(list)).equals("LOGIN:PWINCORRECT"));
		
		list = new LinkedList();
		list.add("lgn");
		user = new User("icho@ucsc.edu", "cofls8680*");
		list.add(user);
		String uid = ((String) SocketClient.request(list));
	}
	
	private static void verification(boolean statement) {
		if (statement) {
			System.out.println("verified");
		} 
		else {
			System.out.println("verification fail.");
		}
	}
}
