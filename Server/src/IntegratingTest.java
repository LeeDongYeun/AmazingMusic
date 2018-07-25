import Testing_IntegratingServer.FunctionalityTest;
import Testing_IntegratingServer.RobustnessTest;
import Testing_IntegratingServer.ValidationTest;

public class IntegratingTest {

	public static void main (String args[]) throws Exception{
		
		/**
		 * Purpose: Test code for the combination of gps and file servers
		 * Input Requirement: nothing
		 * Output: nothing
		 */

		ValidationTest.main(null);
		FunctionalityTest.main(null);
		RobustnessTest.main(null);
	}

}