package Testing_IntegratingServer;

import Request.Request;
import SQLpackage.Database;

public class ValidationTest {

	public static void main(String[] args) throws Exception {
		
		/*
		 * System Validation Tests
		 * 1. Invalid email test. 		Expected result: INVALIDEMAIL
		 * 2. Existing ID test			Expected result: REG:USEREXISTS
		 * 3. Wrong PW test				Expected result: LOGIN:PWINCORRECT
		 * 4. Unregistered ID test		Expected result: LOGIN:NOTREG
		 */
		
		invalidEmail();
		existingID();
		wrongPW();
		unregisteredID();
		
		System.out.println("All tests pass. Done.");
	}
	
	private static void invalidEmail() throws Exception {
		System.out.println("Invalid email test");
		
		if (!Request.register("ciy@sdf@com.com", "sdf").equals("INVALIDEMAIL")) {
			printError(0x01, "ciy@sdf@com.com", "sdf");
			return;
		}
		if (!Request.register("ciy.com", "sdf").equals("INVALIDEMAIL")) {
			printError(0x01, "ciy.com", "sdf");
			return;
		}
		if (!Request.register("ciy405@naver", "sdf").equals("INVALIDEMAIL")) {
			printError(0x01, "ciy405@naver", "sdf");
			return;
		}
		
		System.out.println("Invalid email test pass. Countinue.\n");
	}

	private static void existingID() throws Exception {
		System.out.println("Existing ID test");
		
		String username, domain; 
		
		/*
		 * Four cases are exactly same except the values of username and domain variables.
		 */
		username = "test1*";
		domain = "naver.com";
		existingIDTestCase(username, domain);
		
		username = "2n34l2";
		domain = "idont.wanna.bealone";
		existingIDTestCase(username, domain);
		
		username = "drop";
		domain = "the.be.at";
		existingIDTestCase(username, domain);
		
		username = "whocares?";
		domain = "no.way";
		existingIDTestCase(username, domain);
		
		System.out.println("Existing ID test pass. Countinue.\n");
	}
	
	private static void existingIDTestCase(String username, String domain) throws Exception {
		Database db = new Database();
		// remove the user info if there is existing user.
		String initialize = "delete from `amazingmusicdb`.`userInfo` where `emailUsername`='" + username + "' and `emailDomain`='" + domain + "';";
		db.updateDB(initialize);
		if (!Request.register(username+"@"+domain, "password").equals("UPS")) { // existing email, registration fail
			printError(0x02, username+"@"+domain, "password");
			return;
		} 
		else if (!Request.register(username+"@"+domain, "password").equals("REG:USEREXISTS")){
			printError(0x02, username+"@"+domain, "password");
			return;
		}
	}
	
	private static void wrongPW() throws Exception {
		System.out.println("Wrong PW test");
		
		String username, domain; 
		
		/*
		 * Four cases are exactly same except the values of username and domain variables.
		 */
		username = "1n2lksdf";
		domain = "everything.com";
		wrongPWTestCase(username, domain);
		
		username = "sdnlf333";
		domain = "nothing.co.jp";
		wrongPWTestCase(username, domain);

		username = "ipaddress";
		domain = "but.and.also";
		wrongPWTestCase(username, domain);
		
		username = "toolazytomake";
		domain = "me.too.com";
		wrongPWTestCase(username, domain);
		
		System.out.println("Wrong PW test pass. Countinue.\n");
	}
	
	private static void wrongPWTestCase(String username, String domain) {
		Database db = new Database();
		// remove the user info if there is existing user.
		String initialize = "delete from `amazingmusicdb`.`userInfo` where `emailUsername`='" + username + "' and `emailDomain`='" + domain + "';";
		db.updateDB(initialize);
		try {
			if (!Request.register(username+"@"+domain, "password").equals("UPS")) { // existing email, registration fail
				printError(0x03, username+"@"+domain, "password");
				return;
			} 
			else if (!Request.login(username+"@"+domain, "incorrect").equals("LOGIN:PWINCORRECT")){
				printError(0x03, username+"@"+domain, "incorrect");
				return;
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	private static void unregisteredID() throws Exception {
		System.out.println("Unregistered ID test");
		
		if (!Request.login("1123124u@naver.co.kr", "duwn3823").equals("LOGIN:NOTREG")) { // registration succeed
			printError(0x04, "1123124u@naver.com", "duwn3823");
			return;
		}
		if (!Request.login("5lkekwnvrl@naver.co.kr", "duwnsd3823*").equals("LOGIN:NOTREG")) {
			printError(0x04, "5lkekwnvrl@naver.co.kr", "duwnsd3823*");
			return;
		}
		if (!Request.login("nlkrlwer@naver.com", "").equals("LOGIN:NOTREG")) {
			printError(0x04, "nlkrlwer@naver.com", "");
			return;
		}
		
		System.out.println("Unregistered ID test pass. Countinue.\n");
	}
	
	private static void printError (int i, String e, String p) {
		System.out.print("Test failed at ");
		switch (i) {
		case (0x01): System.out.print("Email validator"); break;
		case (0x02): System.out.print("ID validator"); break;
		case (0x03): System.out.print("PW validator"); break;
		case (0x04): System.out.print("Registration validator"); break;
		default: System.out.println("invalid function.");
		}
		System.out.println(" with " + e + " & " + p);
		System.out.println("Test terminated with error.");
	}
}
