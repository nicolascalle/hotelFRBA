using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FrbaHotel {
    class DBConnection {

        string server = ConfigurationManager.AppSettings["server"].ToString();
        string user = ConfigurationManager.AppSettings["user"].ToString();
        string password = ConfigurationManager.AppSettings["password"].ToString();

        private static readonly DBConnection instance = new DBConnection();
        private SqlConnection connection;
        private string appUsername;

        private DBConnection() { }

        public static DBConnection getInstance() { return instance; }

        public string getAppUsername() { return appUsername; }
        public void setAppUsername(string username) { appUsername = username; }

        public SqlConnection getConnection() {
            if (connection == null ) {
                connection = new SqlConnection();
                connection.ConnectionString = "SERVER=" + server + "\\SQLSERVER2012;DATABASE=GD1C2018;UID=" + user + ";PASSWORD=" + password + ";";
                connection.Open();
            }
            return connection;
        }

        public SqlDataReader executeQuery(String query) {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            command.Dispose();
            return dataReader;
        }

    }
}
