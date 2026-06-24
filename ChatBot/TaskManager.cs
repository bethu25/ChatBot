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
    // - Delete tasks
    internal class TaskManager
    {

        // Database connection object
        DatabaseConnection db = new DatabaseConnection();



        // Adds a new task into MySQL
        public void AddTask
        (
            string title,
            string description,
            DateTime reminder
        )
        {

            using (MySqlConnection conn = db.GetConnection())
            {

                conn.Open();


                string query =
                @"INSERT INTO Tasks
                (Title, Description, ReminderDate)
                VALUES
                (@title,@description,@date)";


                MySqlCommand cmd =
                new MySqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@title", title);

                cmd.Parameters.AddWithValue("@description", description);

                cmd.Parameters.AddWithValue("@date", reminder);


                cmd.ExecuteNonQuery();

            }

        }




        // Gets all tasks for the DataGridView
        public DataTable GetTasks()
        {

            using (MySqlConnection conn = db.GetConnection())
            {

                conn.Open();


                string query =
                "SELECT * FROM Tasks";


                MySqlDataAdapter adapter =
                new MySqlDataAdapter(query, conn);


                DataTable table =
                new DataTable();


                adapter.Fill(table);


                return table;

            }

        }





        // Deletes task from database
        public void DeleteTask(int id)
        {


            using (MySqlConnection conn = db.GetConnection())
            {

                conn.Open();


                string query =
                "DELETE FROM Tasks WHERE TaskID=@id";



                MySqlCommand cmd =
                new MySqlCommand(query, conn);



                cmd.Parameters.AddWithValue("@id", id);



                cmd.ExecuteNonQuery();


            }

        }

        // Method used to mark a task as completed
        // Updates the database Completed column to true
        public void CompleteTask(int taskID)
        {


            // Creates database connection
            using (MySqlConnection conn = db.GetConnection())
            {


                // Opens connection
                conn.Open();



                // SQL command to update task status
                string query =
                "UPDATE Tasks SET Completed=true WHERE TaskID=@id";



                // Creates SQL command
                MySqlCommand cmd =
                new MySqlCommand(query, conn);



                // Prevent SQL injection
                cmd.Parameters.AddWithValue(
                    "@id",
                    taskID
                );



                // Executes update
                cmd.ExecuteNonQuery();


            }


        }

    }
}