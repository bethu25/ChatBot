using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot
{
    internal class CyberBot
    {  
        // Creating object from ResponseManager class
        private ResponseManager manager = new ResponseManager();

        // Dictionary with Lists
        // Stores chatbot responses
        private Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>();

        // Random object for random responses
        Random random = new Random();

        // Memory variables
        private string userName = "";
        private string favouriteTopic = "";
        private string lastTopic = "";


    }
}