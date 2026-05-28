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

        // SENTIMENT DETECTION VARIABLES
        private string currentEmotion = "";
        private bool waitingForEmotionTopic = false;

        // PARAMETARISED METHOD TO SAVE USER NAME

        public void SetUserName(string name)// This method is called when the application starts
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
           
            // Makes keyword recognition easier
            message = message.ToLower(); // Convert message to lowercase

            // MEMORY AND RECALL

            // Remember favourite topic
            if (message.Contains("my favourite topic is"))
            {
                // Remove unnecessary words
                favouriteTopic = message.Replace(
                    "my favourite topic is", "").Trim();

                // Save as last topic
                lastTopic = favouriteTopic;

                return "Great! I will remember that your favourite topic is "
                       + favouriteTopic + ".";
            }

            // Tell user their favourite topic
            else if (message.Contains("what is my favourite topic") ||
                     message.Contains("what's my favourite topic") ||
                     message.Contains("do you remember my favourite topic"))
            {
                // Check if topic exists
                if (favouriteTopic != "")
                {
                    return "Your favourite topic is " + favouriteTopic + ".";
                }

                return "You have not told me your favourite topic yet.";
            }

            // Tell user their name
            else if (message.Contains("what is my name") ||
                     message.Contains("what's my name") ||
                     message.Contains("do you remember my name"))
            {
                // Check if name exists
                if (userName != "")
                {
                    return "Your name is " + userName + ".";
                }

                return "I do not know your name yet.";
            }

            // BOT REMEMBERS USER FAVOURITE TOPIC
            else if (message.Contains("what is my favourite topic") ||
                     message.Contains("what's my favourite topic") ||
                     message.Contains("do you remember my favourite topic"))
            {
                // Check if favourite topic exists
                if (favouriteTopic != "")
                {
                    return "Your favourite topic is " + favouriteTopic + ".";
                }

                return "You have not told me your favourite topic yet.";
            }

            // BOT REMEMBERS USER NAME
            else if (message.Contains("what is my name") ||
                     message.Contains("what's my name") ||
                     message.Contains("do you remember my name"))
            {
                // Check if user name exists
                if (userName != "")
                {
                    return "Your name is " + userName + ".";
                }

                return "I do not know your name yet.";
            }

            // SENTIMENT DETECTION

            // USER IS WORRIED
            else if (message.Contains("worried"))
            {
                currentEmotion = "worried";

                // Bot now asks follow-up question
                waitingForEmotionTopic = true;

                return "I am sorry to hear that, "
                     + userName
                     + ". What are you worried about?";
            }

            // USER IS FRUSTRATED
            else if (message.Contains("frustrated"))
            {
                currentEmotion = "frustrated";

                waitingForEmotionTopic = true;

                return "I understand your frustration, "
                     + userName
                     + ". What cybersecurity topic is frustrating you?";
            }

            // USER IS CURIOUS
            else if (message.Contains("curious"))
            {
                currentEmotion = "curious";

                waitingForEmotionTopic = true;

                return "That is great, "
                     + userName
                     + "! What would you like to learn more about?";
            }

            // HANDLE FOLLOW-UP AFTER EMOTION

            else if (waitingForEmotionTopic)
            {
                // Stop waiting after user replies
                waitingForEmotionTopic = false;

                // PASSWORD
                if (message.Contains("password"))
                {
                    lastTopic = "password";

                    if (currentEmotion == "worried")
                    {
                        return "Do not worry too much, "
                             + userName
                             + ". Here is a password safety tip:\n"
                             + manager.GetRandomTip("password");
                    }

                    else if (currentEmotion == "frustrated")
                    {
                        return "Passwords can feel difficult sometimes, but these tips can help:\n"
                             + manager.GetRandomTip("password");
                    }

                    else if (currentEmotion == "curious")
                    {
                        return "Great question! Here is something interesting about passwords:\n"
                             + manager.GetRandomTip("password");
                    }
                }

                // SCAM
                else if (message.Contains("scam"))
                {
                    lastTopic = "scam";

                    return "Scams are very common online today. Here is a helpful tip:\n"
                         + manager.GetRandomTip("scam");
                }

                // PRIVACY
                else if (message.Contains("privacy"))
                {
                    lastTopic = "privacy";

                    return "Privacy is very important for staying safe online.\n"
                         + manager.GetRandomTip("privacy");
                }

                // PHISHING
                else if (message.Contains("phishing"))
                {
                    lastTopic = "phishing";

                    return "Phishing attacks can be dangerous. Here is a useful tip:\n"
                         + manager.GetRandomTip("phishing");
                }

                // UNKNOWN TOPIC
                return "Can you tell me more about the cybersecurity topic you mean?";
            }

            // FOLLOW-UP QUESTIONS and CONVERSATION FLOW
            else if (message.Contains("tell me more") ||
                     message.Contains("another tip") ||
                     message.Contains("explain more"))
            {
                // Continue previous topic
                if (lastTopic != "")
                {
                    return manager.GetRandomTip(lastTopic);
                }

                return "Please ask about a cybersecurity topic first.";
            }

             // PASSWORD
            else if (message.Contains("password"))
            {
                lastTopic = "password";

                // IF USER ASKS FOR DEFINITION
                if (message.Contains("what is") ||
                    message.Contains("define") ||
                    message.Contains("meaning"))
                {
                    return manager.GetDefinition("password");
                }

                // OTHERWISE RETURN RANDOM TIP
                string response = manager.GetRandomTip("password");

                // Personalised response using user name
                if (userName != "")
                {
                    response += "\nStay safe online, " + userName + "!";
                }

                return response;
            }

             // SCAM
            else if (message.Contains("scam"))
            {
                lastTopic = "scam";

                // Definition request
                if (message.Contains("what is") ||
                    message.Contains("define") ||
                    message.Contains("meaning"))
                {
                    return manager.GetDefinition("scam");
                }

                string response = manager.GetRandomTip("scam");

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

                // Definition request
                if (message.Contains("what is") ||
                    message.Contains("define") ||
                    message.Contains("meaning"))
                {
                    return manager.GetDefinition("privacy");
                }

                string response = manager.GetRandomTip("privacy");

                // Personalised memory response
                if (favouriteTopic == "privacy")
                {
                    response += "\nAs someone interested in privacy, "
                             + "you should review your account settings regularly.";
                }

                // Personalised name recall
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

                // Definition request
                if (message.Contains("what is") ||
                    message.Contains("define") ||
                    message.Contains("meaning"))
                {
                    return manager.GetDefinition("phishing");
                }

                string response = manager.GetRandomTip("phishing");

                if (userName != "")
                {
                    response += "\nAlways stay alert, " + userName + ".";
                }

                return response;
            }

            // GREETINGS

            else if (message.Contains("hello") ||
                     message.Contains("hi"))
            {
                return "Hello again, " + userName +
                       "! Feel free to ask me anything about passwords, scams, privacy or phishing.";
            }

            // EXIT

            else if (message.Contains("bye") ||
                     message.Contains("exit"))
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