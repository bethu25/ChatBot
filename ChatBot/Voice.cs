using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace ChatBot
{
    internal class Voice
    {
        // Method to play WAV audio
        public void PlayVoiceGreeting()
        {
            try
            {
                // Create SoundPlayer object
                SoundPlayer player = new SoundPlayer("Assets/Greeting.wav");

                // Play WAV file
                player.PlaySync();
            }
            catch
            {
                MessageBox.Show(
                    "Could not play the audio file.",
                    "Audio Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
