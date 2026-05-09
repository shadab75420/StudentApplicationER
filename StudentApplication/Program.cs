using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=NFSDB2;Trusted_Connection=True;TrustServerCertificate=True;";

        SqlConnection con = new SqlConnection(connectionString);

        try
        {
            con.Open();
            Console.WriteLine("Database Connected Successfully");

            // INSERT DATA

            string query = @"
                INSERT INTO Students(Name, Age) VALUES('Shadab', 22);
                INSERT INTO Students(Name, Age) VALUES('Abhi', 21);
                INSERT INTO Students(Name, Age) VALUES('Rahul', 23);
            ";

            SqlCommand cmd = new SqlCommand(query, con);

            int rows = cmd.ExecuteNonQuery();

            Console.WriteLine(rows + " Rows Inserted Successfully");


            // READ DATA

            string readQuery = "SELECT * FROM Students";

            SqlCommand readCmd = new SqlCommand(readQuery, con);

            SqlDataReader reader = readCmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Id"] + " " +
                    reader["Name"] + " " +
                    reader["Age"]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection Failed");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
}