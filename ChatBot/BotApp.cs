namespace ChatBot
{
    public partial class BotApp : Form
    {

        private CyberBot cyberbot = new CyberBot();
        private Voice voice = new Voice();
        public BotApp()
        {
            InitializeComponent();
        }

        // Send button click event
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Get user message
            string userMessage = txtUserInput.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please type a message.");
                return;
            }

            // Show user message
            rtbChat.AppendText("You: " + userMessage + Environment.NewLine);

            // Get chatbot response
            string response = cyberbot.GetResponse(userMessage);

            // Show bot response
            rtbChat.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

            // Clear textbox
            txtUserInput.Clear();

        }

        private void BotApp_Load(object sender, EventArgs e)
        {
            voice.PlayVoiceGreeting();

            rtbChat.AppendText(
                "Bot: Welcome to the Cybersecurity Awareness Bot!" +
                Environment.NewLine + Environment.NewLine);
        }
 
    }
}
