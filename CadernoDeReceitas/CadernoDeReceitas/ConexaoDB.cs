using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadernoDeReceitas
{
    class ConexaoDB
    {
        public MySqlConnection connectDB()
        {
            MySqlConnectionStringBuilder dbAccess = new MySqlConnectionStringBuilder();
            dbAccess.Server = "localhost";
            dbAccess.Database = "cadernoReceitas";
            dbAccess.UserID = "root";
            dbAccess.Password = "afaca12345";
            MySqlConnection dbConnection = new MySqlConnection(dbAccess.ToString());
            dbConnection.Open();
            return dbConnection;
        }
    }
}
