using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot
{
    internal class CyberBot
    {
        // Object from ResponseManager class
        private ResponseManager manager = new ResponseManager();

        // MEMORY VARIABLES
        // These variables store user information
        private string userName = "";
        private string favouriteTopic = "";
        private string lastTopic = "";

        // METHOD TO SAVE USER NAME
        // This is used when the application starts
        public void SetUserName(string name)
        {
            userName = name;
        }

        // METHOD TO RETURN USER NAME
        public string GetUserName()
        {
            return userName;
        }

        // MAIN CHATBOT METHOD
        public string GetResponse(string message)
        {
            // Convert message to lowercase
            // Makes keyword recognition easier
            message = message.ToLower();
 
            // MEMORY AND RECALL
          

            // Remember favourite topic
            if (message.Contains("my favourite topic is"))
            {
                // Remove unnecessary words from the sentence
                favouriteTopic = message.Replace(
                    "my favourite topic is", "").Trim();

                // Save as last topic
                lastTopic = favouriteTopic;

                return "Great! I will remember that your favourite topic is "
                       + favouriteTopic + ".";
            }

   
            // SENTIMENT DETECTION

            else if (message.Contains("worried"))
            {
                lastTopic = "scam";

                return "It is understandable to feel worried,especially when percentage of scams is growing dsy by day.\n"
                     + manager.GetRandomResponse("scam");
            }

            else if (message.Contains("frustrated"))
            {
                return "Cybersecurity can feel frustrating sometimes, but learning safety tips helps.";
            }

            else if (message.Contains("curious"))
            {
                return "I am glad you are curious about cybersecurity!";
            }

            // CONVERSATION FLOW

            else if (message.Contains("tell me more") ||
                     message.Contains("another tip") ||
                     message.Contains("explain more"))
            {
                // Continue previous topic
                if (lastTopic != "")
                {
                    return manager.GetRandomResponse(lastTopic);
                }

                return "Please ask about a cybersecurity topic first.";
            }

            // KEYWORD RECOGNITION
            else if (message.Contains("password"))
            {
                lastTopic = "password";

                string response = manager.GetRandomResponse("password");

                // Personalised name recall
                if (userName != "")
                {
                    response += "\nIt is important to stay safe online, " + userName + "!";
                }

                return response;
            }

            // SCAM
            else if (message.Contains("scam"))
            {
                lastTopic = "scam";

                string response = manager.GetRandomResponse("scam");

                // Personalised name recall
                if (userName != "")
                {
                    response += "\nBe careful online, " + userName + ".";
                }

                return response;
            }

            // PRIVACY
            else if (message.Contains("privacy"))
            {
                lastTopic = "privacy";

                string response = manager.GetRandomResponse("privacy");

                // MEMORY RECALL
                if (favouriteTopic == "privacy")
                {
                    response += "\nAs someone interested in privacy, "
                             + "you should review your account settings regularly.";
                }

                // USER NAME RECALL
                if (userName != "")
                {
                    response += "\nStay safe online, " + userName + "!";
                }

                return response;
            }

            // PHISHING
            else if (message.Contains("phishing"))
            {
                lastTopic = "phishing";

                string response = manager.GetRandomResponse("phishing");

                // USER NAME RECALL
                if (userName != "")
                {
                    response += "\nAlways stay alert, " + userName + ".";
                }

                return response;
            }

 
            // GREETINGS
 
            else if (message.Contains("hello") || message.Contains("hi"))
            {
                return "Hello again, " + userName +
                       "! Feel free to ask me anything about passwords, scams, privacy or phishing.";
            }

          
            // EXIT

            else if (message.Contains("bye") || message.Contains("exit"))
            {
                return "Goodbye " + userName + "! Stay safe online.";
            }
          
            // ERROR HANDLING
             
            else
            {
                return "I am not sure I understand. Can you try rephrasing?";
            }
        }
    }
}