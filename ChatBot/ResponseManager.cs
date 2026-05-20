using System;
using System.Text;
using System.Collections.Generic;

namespace ChatBot
{
    internal class ResponseManager
    {
        // Dictionary stores keywords and their responses
        public Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>();


        public ResponseManager()
        {

        }
    }
}