using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBot
{
    internal class CyberBot
    {  
        // object from ResponseManager class
        private ResponseManager manager = new ResponseManager();

        // Memory variables
        private string userName = "";
        private string favouriteTopic = "";
        private string lastTopic = "";

        // This is Main chatbot method
        public string GetResponse(string message)
        {
                   
            // Makes keyword checking easier and Convert text to lowercase
            message = message.ToLower();
           
            // MEMORY AND RECALL
            if (message.Contains("my name is")) // Remember user's name
            {
                // Split sentence into words
                string[] words = message.Split(' ');

                // Store last word as name
                userName = words[words.Length - 1];

                return "Nice to meet you, " + userName + "!";
            }

            // Remember favourite topic
            else if (message.Contains("interested in privacy"))
            {
                favouriteTopic = "privacy";

                return "Great! I will remember that you are interested in privacy.";
            }

             // SENTIMENT DETECTION
              
            else if (message.Contains("worried"))
            {
                lastTopic = "scam";

                return "It is understandable to feel worried about scams. " +
                       manager.GetRandomResponse("scam");
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
 
            // Password
            else if (message.Contains("password"))
            {
                lastTopic = "password";

                return manager.GetRandomResponse("password");
            }

            // Scam
            else if (message.Contains("scam"))
            {
                lastTopic = "scam";

                return manager.GetRandomResponse("scam");
            }

            // Privacy
            else if (message.Contains("privacy"))
            {
                lastTopic = "privacy";

                string response = manager.GetRandomResponse("privacy");

                // Personalised memory response
                if (favouriteTopic == "privacy")
                {
                    response += "\nAs someone interested in privacy, " +
                                "you should review your account settings regularly.";
                }

                // Personalised name recall
                if (userName != "")
                {
                    response += "\nStay safe online, " + userName + "!";
                }

                return response;
            }

            // Phishing
            else if (message.Contains("phishing"))
            {
                lastTopic = "phishing";

                return manager.GetRandomResponse("phishing");
            }

  
            // GREETING
     

            else if (message.Contains("hello") ||
                     message.Contains("hi"))
            {
                if (userName != "")
                {
                    return "Hello again, " + userName + "!";
                }

                return "Hello! Ask me about passwords, scams, privacy or phishing.";
            }

            // EXIT

            else if (message.Contains("bye") ||
                     message.Contains("exit"))
            {
                return "Goodbye! Stay safe online.";
            }

  
            // ERROR HANDLING
    
            else
            {
                return "I am not sure I understand. Can you try rephrasing?";
            }
        }

    }
 }

