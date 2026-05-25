 ChatBot for South Africa citizens 

 Project Overview

The Cybersecurity Awareness Bot is a Windows Forms (WinForms) chatbot application developed in C#. The purpose of the chatbot is to educate users about cybersecurity topics such as passwords, scams, privacy, and phishing.

The chatbot uses:

Keyword recognition
Random responses
Memory and recall
Sentiment detection
Conversation flow
Error handling
Object-Oriented Programming (OOP)

The application also includes:

GUI interface
Voice greeting using WAV audio
Personalized chatbot responses
User memory features
Features
1. Keyword Recognition

The chatbot recognizes cybersecurity keywords such as:

Password
Scam
Privacy
Phishing

Example:

User: Tell me about passwords
Bot: Use strong passwords with letters, numbers and symbols.

2. Random Responses

The chatbot uses random responses to make conversations less repetitive.

Example:

User: Tell me about phishing
Bot: Check email addresses carefully before clicking links.

OR

Bot: Never enter passwords on suspicious websites.
3. Memory and Recall

The chatbot remembers:

User name
Favourite cybersecurity topic
Previous discussion topic

Example:

User: My favourite topic is privacy
Bot: Great! I will remember that your favourite topic is privacy.

Later:

User: Tell me about privacy
Bot: As someone interested in privacy, you should review your account settings regularly.
4. Sentiment Detection

The chatbot detects emotions such as:

Worried
Curious
Frustrated

Example:

User: I am worried about scams
Bot: It is understandable to feel worried...
5. Conversation Flow

The chatbot remembers the previous topic and continues the conversation naturally.

Example:

User: Tell me more
Bot: Use different passwords for different accounts.
6. Voice Greeting

The chatbot plays a WAV audio greeting when the application starts.

7. GUI Design

The project includes:

Background image
Chat area
User input textbox
Send button
Cybersecurity-themed design
Technologies Used
C#
.NET Windows Forms
Visual Studio
OOP Principles
Dictionaries
Lists
Random class
SoundPlayer class
Project Structure
ChatBot
│
├── BotApp.cs
├── CyberBot.cs
├── ResponseManager.cs
├── Voice.cs
├── Assets
│  
└── Greeting.wav
Class Descriptions
1. BotApp.cs

This is the main GUI form.

Responsibilities:

Displays chatbot interface
Handles button clicks
Displays messages
Plays voice greeting
Asks user for name
2. CyberBot.cs

This class contains the chatbot logic.

Responsibilities:

Keyword recognition
Memory and recall
Sentiment detection
Conversation flow
Personalized responses
3. ResponseManager.cs

This class manages all chatbot responses.

Responsibilities:

Stores responses using Dictionary and List
Returns random responses
Organizes chatbot topics
4. Voice.cs

This class handles audio playback.

Responsibilities:

Plays WAV greeting file
Handles audio errors
Setup Instructions
Requirements

Before running the project, install:

Visual Studio 2022
.NET Framework / .NET Windows Forms Support
How to Run the Project
Step 1: Open the Project
Open Visual Studio
Click:
Open a project or solution
Select the ChatBot project folder
Step 2: Add the Audio File

Create a folder named:

Assets

Inside the project directory.

Add:

Greeting.wav

Example:

ChatBot
│
├── Assets
│  
└── Greeting.wav
Step 3: Configure Audio File
In Solution Explorer:
Right-click Greeting.wav
Select Properties
Set:
Build Action = Content
Copy to Output Directory = Copy if newer
Step 4: Run the Application

Press:

F5

OR

Click:

Start
How the Application Works
Application Startup

When the application starts:

Voice greeting plays
User enters their name
Welcome message appears

Example:

Bot: Hello Username! Welcome to the Cybersecurity Awareness Bot.
Bot: Feel free to ask me about passwords, scams, privacy or phishing.
Usage Examples
Greeting Example
User: hello
Bot: Hello again, Username! Feel free to ask me anything about passwords, scams, privacy or phishing.
Password Example
User: tell me about passwords
Bot: Use strong passwords with letters, numbers and symbols.
Scam Example
User: scams
Bot: Scammers often pretend to be trusted companies.
Privacy Example
User: privacy
Bot: Review your privacy settings regularly.
Phishing Example
User: phishing
Bot: Never enter passwords on suspicious websites.
Favourite Topic Example
User: my favourite topic is privacy
Bot: Great! I will remember that your favourite topic is privacy.
Sentiment Example
User: I am worried about scams
Bot: It is understandable to feel worried...
Conversation Flow Example
User: tell me more
Bot: Use different passwords for different accounts.
Exit Example
User: bye
Bot: Goodbye Username! Stay safe online.
OOP Concepts Used
Encapsulation

Classes store data and methods together.

Example:

private string userName = "";
Objects

Objects are created from classes.

Example:

private CyberBot cyberbot = new CyberBot();
Methods

Methods perform specific tasks.

Example:

GetResponse()
Data Structures Used
Dictionary

Used to store chatbot topics and responses.

Example:

Dictionary<string, List<string>>
List

Used to store multiple responses for each topic.

Example:

List<string>
Error Handling

The chatbot prevents:

Application crashes
Empty user messages
Missing audio file errors
Unknown input failures

Example:

Bot: I am not sure I understand. Can you try rephrasing?
GUI Design Features

The GUI includes:

Cybersecurity-themed background
Styled title
RichTextBox for conversation
TextBox for user input
Send button
Proper spacing and alignment
Possible Improvements

Future improvements may include:

AI integration
Database storage
Voice recognition
More cybersecurity topics
Dark mode
Better animations
Author
Cybersecurity Awareness Bot
Developed using C# Windows Forms

Conclusion

This project demonstrates:

GUI development
OOP programming
Event-driven programming
Data structures
User interaction
Cybersecurity education

The chatbot provides users with cybersecurity awareness tips while maintaining natural and personalized conversations.