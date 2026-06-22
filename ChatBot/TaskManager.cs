using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data;


namespace ChatBot
{
    // This class manages all cybersecurity tasks.
    // It allows the chatbot to:
    // - Add tasks
    // - View tasks
    // - Store task information in MySQL
    internal class TaskManager
    {


        // Creates an object of DatabaseConnection
        // This allows this class to access the database
        DatabaseConnection db = new DatabaseConnection();



        // Method used to add a new cybersecurity task
        public void AddTask
        (
            string title,
            string description,
            DateTime reminders
        )
        {


            // Creates a database connection
            using (MySqlConnection conn = db.GetConnection())
            {

                // Opens the connection
                conn.Open();



                // SQL command used to insert a new task
                // into the Tasks table
                string query =
                @"INSERT INTO Tasks
                (Title, Description, ReminderDate)
                VALUES
                (@title,@description,@date)";



                // Creates SQL command
                MySqlCommand cmd =
                new MySqlCommand(query, conn);



                // Prevents SQL injection by using parameters
                cmd.Parameters.AddWithValue
                (
                    "@title",
                    title
                );


                cmd.Parameters.AddWithValue
                (
                    "@description",
                    description
                );


                cmd.Parameters.AddWithValue
                (
                    "@date",
                    reminders
                );



                // Executes the INSERT command
                cmd.ExecuteNonQuery();

            }

        }





        // Method used to retrieve all saved tasks
        // from the database
        public DataTable GetTasks()
        {


            using (MySqlConnection conn = db.GetConnection())
            {


                // Open database connection
                conn.Open();



                // SQL query to display all tasks
                string query =
                "SELECT * FROM Tasks";



                // Adapter transfers database data
                // into a DataTable for the GUI
                MySqlDataAdapter adapter =
                new MySqlDataAdapter(query, conn);



                // Temporary storage for database results
                DataTable table =
                new DataTable();



                // Fill table with database records
                adapter.Fill(table);



                // Return tasks to GUI
                return table;

            }

        }


    }
}