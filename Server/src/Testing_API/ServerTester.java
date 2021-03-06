package Testing_API;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class ServerTester {
	
	public ServerTester() {
		/*
		 * Constructor for Server class.
		 * Serversocket stays to listen a client's request.
		 * If server success to listen and accept the request from a client, 
		 * Create a clientsocket which is connected with a client and
		 * Create another server thread, which do all server work for the client.
		 */
		ServerSocket serverSocket = null;
		Socket clientSocket;
		
		try {
			serverSocket = new ServerSocket(18701);
			// Server, Keep working!
			while (true) {
				clientSocket = serverSocket.accept();
				// Success to listen and accept. Create another server thread.
				new CreateServerThreadTester(clientSocket);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try { 
				if (serverSocket != null) serverSocket.close(); 
			} catch (IOException e) {};
		}
	}
}
