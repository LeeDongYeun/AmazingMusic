package Testing_CoreFunctions;

import java.math.BigInteger;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class MD5test {

	public static void main(String[] args) {
		
		/**
		 * Purpose: Old style(legacy) test code for a MD5 hash function and MessageDigest class.
		 * 			using println()
		 * For further info:
		 * https://en.wikipedia.org/wiki/MD5
		 * https://en.wikipedia.org/wiki/Md5sum
		 */
		
		try {
			String originalText = "BTS says: I need you girl";
			
			MessageDigest md = MessageDigest.getInstance("MD5");
			md.reset();
			md.update(originalText.getBytes());
			byte[] digest = md.digest();
			
			BigInteger bigInt = new BigInteger(1,digest);
			String hashtext = bigInt.toString(16);
			
			System.out.println("Hash value should be random-looking: "+hashtext);
			System.out.println("Character length should be 32: "+hashtext.length());
			
		} catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
		}
	}

}
