using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace ChatBot
{
    // This class is responsible for creating a connection
    // between the chatbot application and the MySQL database
    internal class DatabaseConnection
    {

        // Connection string contains the information required
        // to connect to the CyberBotDB database
        private string connectionString =
        "server=localhost;database=CyberBotDB;uid=root;password=Mok@kole25;";


        // This method returns an openable database connection
        // Other classes can use this method when they need
        // to communicate with MySQL
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}