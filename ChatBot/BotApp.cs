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
        {// Play WAV greeting
            

            // Ask user for their name
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter your name:",
                "Cybersecurity Awareness Bot"
               
            );

            // Input validation
            if (name == "")
            {
                name = "User";
            }

            // Save name into chatbot memory
            cyberbot.SetUserName(name);
           
            voice.PlayVoiceGreeting();
            // Display welcome message
            rtbChat.AppendText(
                "Bot: Hello " + cyberbot.GetUserName() +
                "! Welcome to the Cybersecurity Awareness Bot.\n"
            );

            rtbChat.AppendText(
                "Bot: Feel free to ask me about passwords, scams, privacy or phishing.\n\n"
            );
        }
 
    }
}
