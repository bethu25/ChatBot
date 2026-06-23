using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot
{
    // This class stores chatbot actions
    // Example:
    // Quiz started
    // Task added
    // Reminder created

    internal class ActivityLogger
    {

 
        // Stores logs
        private List<string> logs =
        new List<string>();



        // Add new action

        public void AddLog(string action)
        {

            logs.Add(
            DateTime.Now +
            " - " +
            action);

        }
 


        // Return logs to GUI

        public List<string> GetLogs()
        {

            return logs;

        }


    }
}
