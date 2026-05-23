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
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSend.BackColor = SystemColors.ButtonShadow;
            btnSend.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(613, 351);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(247, 31);
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
            lblTitle.Location = new Point(281, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 26);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = SystemColors.InactiveCaption;
            rtbChat.Cursor = Cursors.IBeam;
            rtbChat.ForeColor = SystemColors.MenuText;
            rtbChat.Location = new Point(12, 91);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(848, 216);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.BackColor = SystemColors.InactiveCaption;
            txtUserInput.Location = new Point(12, 351);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(595, 31);
            txtUserInput.TabIndex = 3;
            // 
            // BotApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(896, 434);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChat);
            Controls.Add(lblTitle);
            Controls.Add(btnSend);
            Name = "BotApp";
            Text = " MyApp";
            Load += BotApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label lblTitle;
        private RichTextBox rtbChat;
        private TextBox txtUserInput;
    }
}
