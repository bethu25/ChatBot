using System;
using System.Text;
using System.Collections.Generic;

namespace ChatBot
{
    internal class ResponseManager
    {
        // DEFINITIONS
        private Dictionary<string, string> definitions =
            new Dictionary<string, string>();

        // TIPS / RESPONSES
        private Dictionary<string, List<string>> tips =
            new Dictionary<string, List<string>>();

        // Random response object
        Random random = new Random();

        // Constructor
        public ResponseManager()
        {
            // PASSWORD
            definitions.Add("password",
                "A password is a secret combination of characters used to verify your identity and protect your accounts.");

            tips.Add("password", new List<string>()
            {
                "Use strong passwords with letters, numbers and symbols.",
                "Avoid using personal information in passwords.",
                "Use different passwords for different accounts.",
                "Change your passwords regularly."
            });

            // SCAM
            definitions.Add("scam",
                "A scam is a dishonest scheme used to trick people into giving away money or personal information.");

            tips.Add("scam", new List<string>()
            {
                "Do not click suspicious email links.",
                "Scammers often pretend to be trusted companies.",
                "Always verify messages before sharing information.",
                "Be careful of offers that sound too good to be true."
            });

            // PRIVACY
            definitions.Add("privacy",
                "Privacy is the ability to keep your personal information safe from others.");

            tips.Add("privacy", new List<string>()
            {
                "Review your privacy settings regularly.",
                "Do not share personal information online.",
                "Keep your social media accounts private.",
                "Use two-factor authentication for extra security."
            });

            // PHISHING
            definitions.Add("phishing",
                "Phishing is a cyberattack where scammers pretend to be trusted organizations to steal information.");

            tips.Add("phishing", new List<string>()
            {
                "Check email addresses carefully before clicking links.",
                "Phishing emails often create urgency.",
                "Never enter passwords on suspicious websites.",
                "Avoid downloading unknown attachments."
            });
        }

        // GET DEFINITION
        public string GetDefinition(string topic)
        {
            if (definitions.ContainsKey(topic))
            {
                return definitions[topic];
            }

            return "Definition not found.";
        }

        // GET RANDOM TIP
        public string GetRandomTip(string topic)
        {
            if (tips.ContainsKey(topic))
            {
                List<string> topicTips = tips[topic];

                int index = random.Next(topicTips.Count);

                return topicTips[index];
            }

            return "No tips found.";
        }
    }
}