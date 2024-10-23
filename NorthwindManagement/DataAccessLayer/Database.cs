using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindManagement.DataAccessLayer
{
    internal static class Database
    {
        public static SqlConnection Connection { get; set; }=CreateConnection();
        private static SqlConnection CreateConnection()
        {
     
            string connectionString = "Server=DESKTOP-48fdf8APMT\\SQLEXPRESS56502;";
            connectionString += "Database=Northwind;";
            connectionString += "User=bbbb;Password=123456487;";
            connectionString += "TrustServerCertificate=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static void ConnectDb()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public static void DisconnectDb()
        {
            if(Connection.State==ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
