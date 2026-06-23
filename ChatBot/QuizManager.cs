using System;
using System.Collections.Generic;
using System.Text;


namespace ChatBot
{

    // This class controls the cybersecurity quiz.
    // It stores questions, answers, score,
    // and controls moving between questions.
    internal class QuizManager
    {

        // Stores questions
        private List<string> questions = new List<string>()
        {

            "What should you do when you receive a suspicious email asking for your password?",

            "Which makes a strong password?",

            "Does two-factor authentication improve security?",

            "What is a common sign of an online scam?",

            "What protects your online privacy?",

            "What is malware?",

            "Why should you avoid unknown links?",

            "Social engineering attacks target what?",

            "Is using the same password everywhere safe?",

            "Why are software updates important?"

        };



        // Stores answer options
        private List<string[]> answers = new List<string[]>()
        {

            new string[]
            {
                "Reply with password",
                "Report phishing",
                "Click link",
                "Ignore"
            },


            new string[]
            {
                "Your birthday",
                "Password123",
                "Letters numbers symbols",
                "Your name"
            },


            new string[]
            {
                "True",
                "False",
                "Maybe",
                "No"
            },


            new string[]
            {
                "Urgency and requests for information",
                "Normal email",
                "A game",
                "A video"
            },


            new string[]
            {
                "Share everything",
                "Review privacy settings",
                "Accept everyone",
                "Give passwords"
            },


            new string[]
            {
                "Harmful software",
                "A browser",
                "A password",
                "A website"
            },


            new string[]
            {
                "Security",
                "Malware/phishing",
                "Updates",
                "Games"
            },


            new string[]
            {
                "People",
                "Internet speed",
                "Computer screen",
                "Keyboard"
            },


            new string[]
            {
                "True",
                "False",
                "Sometimes",
                "Always"
            },


            new string[]
            {
                "Fix security problems",
                "Delete internet",
                "Reduce security",
                "Remove passwords"
            }

        };



        // Correct answers index
        private int[] correctAnswers =
        {
            1,2,0,0,1,0,1,0,1,0
        };



        private int currentQuestion = 0;

        private int score = 0;



        // Starts quiz
        public void StartQuiz()
        {

            currentQuestion = 0;

            score = 0;

        }



        // Returns current question
        public string GetQuestion()
        {

            return questions[currentQuestion];

        }



        // Returns answers
        public string GetAnswerA()
        {
            return answers[currentQuestion][0];
        }


        public string GetAnswerB()
        {
            return answers[currentQuestion][1];
        }


        public string GetAnswerC()
        {
            return answers[currentQuestion][2];
        }


        public string GetAnswerD()
        {
            return answers[currentQuestion][3];
        }



        // Checks user's answer
        public bool CheckAnswer(int answer)
        {

            if (answer == correctAnswers[currentQuestion])
            {

                score++;

                return true;

            }


            return false;

        }




        // Moves to next question
        public bool NextQuestion()
        {

            currentQuestion++;


            if (currentQuestion >= questions.Count)
            {

                return false;

            }


            return true;

        }

        // Moves back to previous question
        public void PreviousQuestion()
        {


            // Prevent going before question 1
            if (currentQuestion > 0)
            {

                currentQuestion--;

            }


        }


        // Returns final score
        public int GetScore()
        {

            return score;

        }


    }
}