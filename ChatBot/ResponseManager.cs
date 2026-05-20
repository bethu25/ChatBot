using System;
using System.Text;
using System.Collections.Generic;

namespace ChatBot
{
    internal class ResponseManager
    {
        // Dictionary stores keywords and their responses
        public Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>();

        // Random object
        Random random = new Random();

        // Constructor
        public ResponseManager()
        {
 
            // Password responses
            responses.Add("password", new List<string>()
            {  "A Password is a secret combination of characters used to verify your identity and grant access to a computer system,line account, or other secured resource.  ",
                "Here are some password tips:", 
                "Use strong passwords with letters, numbers and symbols.",
                "Avoid using personal information in passwords.",
                "Use different passwords for different accounts."
            });

            // Scam responses
            responses.Add("scam", new List<string>()
            {  "Email (Electronic mail) is a mode of exchanging messages among people through electronic devices.",
                "Safety tips:",
                "Do not click suspicious email links.",
                "Scammers often pretend to be trusted companies.",
                "Always verify messages before sharing information."
            });

            // Privacy responses
            responses.Add("privacy", new List<string>()
            {   "a state in which one is not observed or disturbed by other people",
                "Tips to obtain privacy:",
                "Review your privacy settings regularly.",
                "Do not share personal information online.",
                "Keep your social media accounts private."
            });

            // Phishing responses
            responses.Add("phishing", new List<string>()
            {
                "Phishing is a type of cyberattack where attackers deceive individuals into revealing sensitive information or installing malware by impersonating trusted sources.",
                "Safty tips:",
                "Check email addresses carefully before clicking links.",
                "Phishing emails often create urgency.",
                "Never enter passwords on suspicious websites."
            });
        }

        // Method to return random responses
        public string GetRandomResponse(string topic)
        {
            // Check if topic exists
            if (responses.ContainsKey(topic))
            {
                // Store list in variable
                List<string> topicResponses = responses[topic];

                // Generate random index
                int index = random.Next(topicResponses.Count);

                // Return random response
                return topicResponses[index];
            }

            return "No response found.";
        }
    }
}
