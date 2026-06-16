namespace ChatBot
{
    partial class BotApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotApp));
            btnSend = new Button();
            lblTitle = new Label();
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            tabWindow = new TabControl();
            tabChat = new TabPage();
            tabTasks = new TabPage();
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            txtDescription = new TextBox();
            txtTaskTitle = new TextBox();
            tabQuiz = new TabPage();
            btnStartQuiz = new Button();
            btnNextQuestion = new Button();
            lblScore = new Label();
            btnAnswerD = new Button();
            btnAnswerC = new Button();
            btnAnswerB = new Button();
            btnAnswerA = new Button();
            lblQuestion = new Label();
            tabActivity = new TabPage();
            btnShowLogs = new Button();
            lstActivityLog = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            tabWindow.SuspendLayout();
            tabChat.SuspendLayout();
            tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabQuiz.SuspendLayout();
            tabActivity.SuspendLayout();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSend.BackColor = SystemColors.ActiveCaption;
            btnSend.Font = new Font("Felix Titling", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(750, 288);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(236, 31);
            btnSend.TabIndex = 0;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaptionText;
            lblTitle.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Cyan;
            lblTitle.Location = new Point(517, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 26);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = SystemColors.InactiveCaption;
            rtbChat.ForeColor = SystemColors.MenuText;
            rtbChat.Location = new Point(6, 8);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(998, 229);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.BackColor = SystemColors.InactiveCaption;
            txtUserInput.Location = new Point(6, 288);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(738, 31);
            txtUserInput.TabIndex = 3;
            // 
            // tabWindow
            // 
            tabWindow.Controls.Add(tabChat);
            tabWindow.Controls.Add(tabTasks);
            tabWindow.Controls.Add(tabQuiz);
            tabWindow.Controls.Add(tabActivity);
            tabWindow.Location = new Point(51, 48);
            tabWindow.Name = "tabWindow";
            tabWindow.SelectedIndex = 0;
            tabWindow.Size = new Size(1015, 385);
            tabWindow.TabIndex = 8;
            // 
            // tabChat
            // 
            tabChat.Controls.Add(rtbChat);
            tabChat.Controls.Add(txtUserInput);
            tabChat.Controls.Add(btnSend);
            tabChat.Location = new Point(4, 34);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(1007, 347);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chatbot";
            tabChat.UseVisualStyleBackColor = true;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(dateTimePicker1);
            tabTasks.Controls.Add(dgvTasks);
            tabTasks.Controls.Add(btnAddTask);
            tabTasks.Controls.Add(txtDescription);
            tabTasks.Controls.Add(txtTaskTitle);
            tabTasks.Location = new Point(4, 34);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(1007, 347);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Task Assistant";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(446, 6);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.Size = new Size(360, 225);
            dgvTasks.TabIndex = 4;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(501, 249);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(195, 69);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 1;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(195, 16);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(150, 31);
            txtTaskTitle.TabIndex = 0;
            // 
            // tabQuiz
            // 
            tabQuiz.Controls.Add(btnStartQuiz);
            tabQuiz.Controls.Add(btnNextQuestion);
            tabQuiz.Controls.Add(lblScore);
            tabQuiz.Controls.Add(btnAnswerD);
            tabQuiz.Controls.Add(btnAnswerC);
            tabQuiz.Controls.Add(btnAnswerB);
            tabQuiz.Controls.Add(btnAnswerA);
            tabQuiz.Controls.Add(lblQuestion);
            tabQuiz.Location = new Point(4, 34);
            tabQuiz.Name = "tabQuiz";
            tabQuiz.Padding = new Padding(3);
            tabQuiz.Size = new Size(1007, 347);
            tabQuiz.TabIndex = 2;
            tabQuiz.Text = "Quiz";
            tabQuiz.UseVisualStyleBackColor = true;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(343, 274);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(112, 34);
            btnStartQuiz.TabIndex = 14;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new Point(503, 274);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(154, 34);
            btnNextQuestion.TabIndex = 13;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(211, 271);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 25);
            lblScore.TabIndex = 12;
            lblScore.Text = "Score";
            // 
            // btnAnswerD
            // 
            btnAnswerD.Location = new Point(202, 183);
            btnAnswerD.Name = "btnAnswerD";
            btnAnswerD.Size = new Size(112, 34);
            btnAnswerD.TabIndex = 11;
            btnAnswerD.Text = "AnswerD";
            btnAnswerD.UseVisualStyleBackColor = true;
            btnAnswerD.Click += btnAnswerD_Click;
            // 
            // btnAnswerC
            // 
            btnAnswerC.Location = new Point(202, 143);
            btnAnswerC.Name = "btnAnswerC";
            btnAnswerC.Size = new Size(112, 34);
            btnAnswerC.TabIndex = 10;
            btnAnswerC.Text = "AnswerC";
            btnAnswerC.UseVisualStyleBackColor = true;
            btnAnswerC.Click += btnAnswerC_Click;
            // 
            // btnAnswerB
            // 
            btnAnswerB.Location = new Point(202, 103);
            btnAnswerB.Name = "btnAnswerB";
            btnAnswerB.Size = new Size(112, 34);
            btnAnswerB.TabIndex = 9;
            btnAnswerB.Text = "AnswerB";
            btnAnswerB.UseVisualStyleBackColor = true;
            btnAnswerB.Click += btnAnswerB_Click;
            // 
            // btnAnswerA
            // 
            btnAnswerA.Location = new Point(202, 63);
            btnAnswerA.Name = "btnAnswerA";
            btnAnswerA.Size = new Size(112, 34);
            btnAnswerA.TabIndex = 8;
            btnAnswerA.Text = "AnswerA";
            btnAnswerA.UseVisualStyleBackColor = true;
            btnAnswerA.Click += btnAnswerA_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(202, 5);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(84, 25);
            lblQuestion.TabIndex = 7;
            lblQuestion.Text = "Question";
            // 
            // tabActivity
            // 
            tabActivity.Controls.Add(btnShowLogs);
            tabActivity.Controls.Add(lstActivityLog);
            tabActivity.Location = new Point(4, 34);
            tabActivity.Name = "tabActivity";
            tabActivity.Padding = new Padding(3);
            tabActivity.Size = new Size(1007, 347);
            tabActivity.TabIndex = 3;
            tabActivity.Text = "Activity Log";
            tabActivity.UseVisualStyleBackColor = true;
            // 
            // btnShowLogs
            // 
            btnShowLogs.Location = new Point(732, 285);
            btnShowLogs.Name = "btnShowLogs";
            btnShowLogs.Size = new Size(112, 34);
            btnShowLogs.TabIndex = 1;
            btnShowLogs.Text = "Show Logs";
            btnShowLogs.UseVisualStyleBackColor = true;
            btnShowLogs.Click += btnShowLogs_Click;
            // 
            // lstActivityLog
            // 
            lstActivityLog.FormattingEnabled = true;
            lstActivityLog.Location = new Point(45, 40);
            lstActivityLog.Name = "lstActivityLog";
            lstActivityLog.Size = new Size(642, 279);
            lstActivityLog.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // BotApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1117, 458);
            Controls.Add(tabWindow);
            Controls.Add(lblTitle);
            Cursor = Cursors.IBeam;
            Name = "BotApp";
            Text = " MyApp";
            Load += BotApp_Load;
            tabWindow.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabChat.PerformLayout();
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabQuiz.ResumeLayout(false);
            tabQuiz.PerformLayout();
            tabActivity.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblTitle;
        private RichTextBox rtbChat;
        private TextBox txtUserInput;
        private TabControl tabWindow;
        private TabPage tabChat;
        private TabPage tabTasks;
        private TabPage tabQuiz;
        private TabPage tabActivity;
        private Label lblQuestion;
        private Button btnAnswerD;
        private Button btnAnswerC;
        private Button btnAnswerB;
        private Button btnAnswerA;
        private Button btnNextQuestion;
        private Label lblScore;
        private TextBox txtTaskTitle;
        private ListBox lstActivityLog;
        private DataGridView dgvTasks;
        private Button btnAddTask;
        private TextBox txtDescription;
        private Button btnStartQuiz;
        private Button btnShowLogs;
        private DateTimePicker dateTimePicker1;
    }
}
