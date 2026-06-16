namespace ChatBot
{
    public partial class BotApp : Form
    {

        private CyberBot cyberbot = new CyberBot();
        private Voice voice = new Voice();

        // NEW FEATURES
        private TaskManager taskManager = new TaskManager();

        private ActivityLogger logger = new ActivityLogger();

        private QuizManager quiz = new QuizManager();
        public BotApp()
        {
            InitializeComponent();
        }

        // Send button click event
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Get user message
            string message = txtUserInput.Text;

            // Prevent empty messages
            if (message == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // Display user message
            rtbChat.AppendText(
                cyberbot.GetUserName() + ": " + message + "\n"
            );

            // Get bot response
            string response = cyberbot.GetResponse(message);

            // Display response
            rtbChat.AppendText(
                "Bot: " + response + "\n\n"
            );

            // Clear textbox
            txtUserInput.Clear();
        }


        private void BotApp_Load(object sender, EventArgs e)
        {

            // Ask user for their name
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter your name:",
                "Cybersecurity Awareness Bot"

            );

            // Input validation
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            // Save name into chatbot memory
            cyberbot.SetUserName(name);

            //voice.PlayVoiceGreeting();//  welcome message as a voice greeting
            // Display welcome message
            rtbChat.AppendText(
                "Bot: Hello " + cyberbot.GetUserName() +
                "! Welcome to the Cybersecurity Awareness Bot.\n"
            );

            rtbChat.AppendText(
                "Bot: Feel free to ask me about passwords, scams, privacy or phishing.\n\n"
            );

            // MySql database object
            DatabaseConnection db = new DatabaseConnection();


            try
            {
                db.GetConnection().Open();

                MessageBox.Show(
                "Database Connected Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Hide quiz controls until quiz starts

            lblQuestion.Text = "Press Start Quiz to begin";


            btnAnswerA.Visible = false;
            btnAnswerB.Visible = false;
            btnAnswerC.Visible = false;
            btnAnswerD.Visible = false;


            btnNextQuestion.Visible = false;


        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {

            // Start the quiz
            quiz.StartQuiz();


            // Display first question
            lblQuestion.Text = quiz.GetQuestion();



            // Display answers on buttons
            btnAnswerA.Text = quiz.GetAnswerA();

            btnAnswerB.Text = quiz.GetAnswerB();

            btnAnswerC.Text = quiz.GetAnswerC();

            btnAnswerD.Text = quiz.GetAnswerD();

            // Show buttons

            btnAnswerA.Visible = true;
            btnAnswerB.Visible = true;
            btnAnswerC.Visible = true;
            btnAnswerD.Visible = true;
            btnStartQuiz.Visible = false;

            btnNextQuestion.Visible = true;



            // Add activity log
            logger.AddLog("Quiz started");


        }

        // This method updates the score label
        private void UpdateScore()
        {

            lblScore.Text =
            "Score: "
            + quiz.GetScore();

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            // Move to next question
            bool exists = quiz.NextQuestion();



            if (exists)
            {


                // Update question
                lblQuestion.Text = quiz.GetQuestion();



                // Update answers

                btnAnswerA.Text = quiz.GetAnswerA();

                btnAnswerB.Text = quiz.GetAnswerB();

                btnAnswerC.Text = quiz.GetAnswerC();

                btnAnswerD.Text = quiz.GetAnswerD();


            }

            else
            {


                MessageBox.Show(
                "Quiz completed. Your score: "
                + quiz.GetScore()
                + "/10");


                logger.AddLog(
                "Quiz completed");


            }


        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            if (quiz.CheckAnswer(0))
            {

                MessageBox.Show(
                "Correct!");


            }
            else
            {

                MessageBox.Show(
                "Wrong answer.");

            }

            UpdateScore();
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            if (quiz.CheckAnswer(1))
            {

                MessageBox.Show("Correct!");

            }
            else
            {

                MessageBox.Show("Wrong!");

            }
            UpdateScore();
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            if (quiz.CheckAnswer(2))
            {

                MessageBox.Show("Correct!");

            }
            else
            {

                MessageBox.Show("Wrong!");

            }
            UpdateScore();
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            if (quiz.CheckAnswer(3))
            {

                MessageBox.Show("Correct!");

            }
            else
            {

                MessageBox.Show("Wrong!");

            }
            UpdateScore();
        }


        private void btnShowLogs_Click(object sender, EventArgs e)
        {
            // Clear old data

            lstActivityLog.Items.Clear();



            // Load logs

            foreach (string log in logger.GetLogs())
            {


                lstActivityLog.Items.Add(log);


            }
        }
        private void LoadTasks()
          {
 
                   dgvTasks.DataSource =
                   taskManager.GetTasks();
 
          }
       

        private void btnAddTask_Click(object sender, EventArgs e)
        {   
            // Add task into MySQL database
            taskManager.AddTask(

                txtTaskTitle.Text,

                txtDescription.Text,

                dateTimePicker1.Value

            );


            // Add action to activity log
            logger.AddLog(
                "Task added: " + txtTaskTitle.Text
            );


            MessageBox.Show(
                "Task added successfully!"
            );
            // Refresh task list after adding
            LoadTasks();

        }
           

    }


}

