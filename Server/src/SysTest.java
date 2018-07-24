import java.net.Socket;

import Testing_IntegratingServer.FunctionalityTest;
import Testing_IntegratingServer.RobustnessTest;
import Testing_IntegratingServer.ValidationTest;

public class SysTest {

	public static void main (String args[]) throws Exception{
		
		/**
		 * Purpose: Test code for the combination of gps and file servers
		 * Input Requirement: nothing
		 * Output: nothing
		 */

		/*
		 * Things to change
		 * Download.java - localCache
		 * FunctionalityTest.java - new Download(~here~); (url part)
		 */
		ValidationTest.main(null);
		FunctionalityTest.main(null);
		//RobustnessTest.main(null);
	}

}