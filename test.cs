
using System.Data.SqlClient;

public void GetUser(string userInput)
{
    string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'"; // ❌ vulnerable
    using (SqlConnection conn = new SqlConnection("connection-string"))
    {
        SqlCommand cmd = new SqlCommand(query, conn);
        conn.Open();
        cmd.ExecuteReader();
    }
}
