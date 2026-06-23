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
            btnPrevious.Visible = false;

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
            btnPrevious.Visible = true;

            // Hide score label when starting a new quiz
            // Score will only appear when quiz finishes
            lblScore.Text = "";


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


                // Display final score on the label
                lblScore.Text =
                "Your final score: "
                + quiz.GetScore()
                + "/10";



                // Show completion message
                MessageBox.Show(
                "Quiz completed!"
                );



                // Add activity log
                logger.AddLog(
                "Quiz completed with score: "
                + quiz.GetScore()
                + "/10"
                );



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

                dtReminder.Value


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

        // Check if user selected a row
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

            // Check if the user selected a task
            if (dgvTasks.SelectedRows.Count == 0)
            {

                MessageBox.Show(
                    "Please select a task before deleting.",
                    "No Task Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;

            }



            // Get the selected task ID
            int taskID = Convert.ToInt32(
                dgvTasks.SelectedRows[0]
                .Cells["TaskID"].Value
            );



            // Ask user for confirmation before deleting
            DialogResult confirm = MessageBox.Show(

                "Are you sure you want to delete this task?\n\n" +
                "This action cannot be undone.",

                "Confirm Task Deletion",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Warning

            );



            // If user clicks YES
            if (confirm == DialogResult.Yes)
            {


                try
                {

                    // Delete task from database
                    taskManager.DeleteTask(taskID);



                    // Record action in activity log
                    logger.AddLog(
                        "Deleted task ID: " + taskID
                    );



                    MessageBox.Show(

                        "Task deleted successfully!",

                        "Delete Complete",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Information

                    );



                    // Refresh the task list
                    LoadTasks();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(

                        "Error deleting task:\n" + ex.Message,

                        "Delete Error",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Error

                    );

                }


            }


            // If user clicks NO
            else
            {

                MessageBox.Show(

                    "Task deletion cancelled.",

                    "Cancelled",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Information

                );

            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Move back one question
            quiz.PreviousQuestion();


            // Display previous question
            lblQuestion.Text = quiz.GetQuestion();



            // Reload answers
            btnAnswerA.Text = quiz.GetAnswerA();

            btnAnswerB.Text = quiz.GetAnswerB();

            btnAnswerC.Text = quiz.GetAnswerC();

            btnAnswerD.Text = quiz.GetAnswerD();



            // Add activity log
            logger.AddLog("Moved to previous quiz question");


        }
    }


}

