package Object;

import Util.MD5Class;

public class User implements java.io.Serializable {
	
	/*
	 * User class is used to store an user's information
	 * Such as email, password, and uid(user id)
	 * Uid is the number that the servers uses to identify each user. 
	 * Of course, email and password can identify users, 
	 * but it would be more convenient to use only one number.
	 */
	
	private static final long serialVersionUID = 1284470853593107085L;
	private String emailUserName, emailDomain, uid, pw;
	private String errorCode = "FINE";
	
	public User() {} // Used to check whether an object is User type
	
	public User(String email, String pw) {
		
		/*
		 * uid is generated in User() constructor.
		 * which means, client machine is resposible for generating uid.
		 * which means, server's load(calculating) is reduced
		 */
		
		if(!isValidEmail(email))
			this.errorCode = "INVALIDEMAIL";
		else {
			String[] parts = email.split("@");
			this.emailUserName = parts[0];
			this.emailDomain = parts[1];
			this.pw = pw;
			// MD5 is a kind of random number generator.
			// Theoretically, this produces an unique number in probability every time.
			// output is 32 length string. input is unlimited length string.
			this.uid = MD5Class.MD5Generator(email).substring(0, 10); 
		}
	}

	private static boolean isValidEmail(String email) {
		
		/**
		 * Purpose: check the validity of email String.
		 * Exact the same code in User.java
		 */
		if (email.split("@").length != 2 || email.split("@")[1].split("\\.").length < 2)
			/*
			 * if there are more than one @ in email, or
			 * if there are less than two . in email domain,
			 * then the email is invalid.
			 */
			return false;
		else 
			return true;
	}
		
	public String getName() { 
		return this.emailUserName;
	}
	
	public String getDomain() {
		return this.emailDomain;
	}
	
	public String getUserPW() { 
		return this.pw;
	}
	
	public String getUID() {
		return this.uid;
	}
	
	public String getErrorCode() {
		return this.errorCode;
	}
}

