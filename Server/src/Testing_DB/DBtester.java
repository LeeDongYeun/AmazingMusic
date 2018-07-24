package Testing_DB;

import java.sql.ResultSet;
import java.sql.SQLException;

import SQLpackage.Database;

public class DBtester {

	public static void main(String[] args) {
		
		/*
		 * This test code may be no longer working.
		 */
		
		/*
		 * Basic DB connection testing.
		 * Read all rows from userInfo, 
		 * then print the first column of first row.
		 */
		String query = "select * from `amazingmusicdb`.`userInfo`;";
		Database db = new Database();
		ResultSet rs = null;
		
		try {
			rs = db.readDB(query);
			if (rs != null) {
				while (rs.next()) {
					System.out.println(rs.getString(1)+"\t"+rs.getString(2)+"\t"+rs.getString(3)+"\t"+rs.getString(4));
				}
			}
		} catch (SQLException e) {
			System.out.println("DBtester: Something wrong");
		}
	}
}