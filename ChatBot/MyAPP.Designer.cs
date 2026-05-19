namespace ChatBot
{
    partial class MyAPP
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
            btnSend = new Button();
            lblTitle = new Label();
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(619, 351);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 0;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(226, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(35, 91);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(729, 144);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(35, 354);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(592, 31);
            txtUserInput.TabIndex = 3;
            // 
            // MyAPP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChat);
            Controls.Add(lblTitle);
            Controls.Add(btnSend);
            Name = "MyAPP";
            Text = "MyAPP";
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
