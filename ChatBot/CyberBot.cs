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

        // Constructor
        public CyberBot()
        {
            // PASSWORD RESPONSES
            responses.Add("password", new List<string>()
            {
                "Use strong passwords with letters, numbers and symbols.",
                "Avoid using your personal information in passwords.",
                "Use different passwords for different accounts."
            });

            // SCAM RESPONSES
            responses.Add("scam", new List<string>()
            {
                "Do not click suspicious email links.",
                "Scammers often pretend to be trusted companies.",
                "Always verify messages before sharing information."
            });

            // PRIVACY RESPONSES
            responses.Add("privacy", new List<string>()
            {
                "Review your privacy settings regularly.",
                "Do not share personal information online.",
                "Keep your social media accounts private."
            });

            // PHISHING RESPONSES
            responses.Add("phishing", new List<string>()
            {
                "Check email addresses carefully before clicking links.",
                "Phishing emails often create panic or urgency.",
                "Never enter passwords on suspicious websites."
            });
        }
    }
}