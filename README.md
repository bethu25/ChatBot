 ChatBot for South Africa citizens 
 
## Project Overview

The Cybersecurity Awareness Bot is a Windows Forms (WinForms) chatbot application developed in C#. The purpose of this application is to educate users about cybersecurity topics such as passwords, scams, phishing, and privacy.

The chatbot uses:

* GUI interaction using Windows Forms
* Keyword recognition
* Random responses
* Sentiment detection
* Memory and recall
* Conversation flow
* WAV voice greeting
* Dictionaries and Lists for data storage
* Object-Oriented Programming principles

This project was created for Part 2 of the Cybersecurity Awareness Chatbot assignment.



# Features

## 1. GUI Interface

The chatbot uses a graphical user interface built with Windows Forms.

### GUI Components

* RichTextBox for displaying conversations
* TextBox for user input
* Send Button
* Labels and colours for user-friendly design

The GUI was designed to be:

* Simple
* Beginner friendly
* Easy to read
* Interactive



## 2. Voice Greeting

The chatbot plays a WAV audio greeting when the application starts.

The audio is played using:

```
System.Media.SoundPlayer
```

Example:

```
SoundPlayer player = new SoundPlayer("Assets/Greeting.wav");
player.PlaySync();
```

---

## 3. Keyword Recognition

The chatbot recognises cybersecurity-related keywords and responds appropriately.

### Supported Topics

* Password
* Scam
* Privacy
* Phishing

Example:

![Image Alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-05-28%20162254.png?raw=true )  

## 4. Random Responses

The chatbot uses Lists and Random objects to return different responses each time.

Example:

 ![Image Alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-05-28%20162948.png?raw=true)

## 5. Memory and Recall

The chatbot remembers:

* User name
* Favourite cybersecurity topic

### Example
 ![Image Alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-05-28%20162835.png?raw=true)

## 6. Sentiment Detection

The chatbot detects emotions such as:

* Worried
* Curious
* Frustrated

The chatbot responds naturally by asking follow-up questions.

### Example
 ![Image Alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-05-28%20163137.png?raw=true)
 
## 7. Conversation Flow

The chatbot continues conversations naturally.

Example:

 ![Image Alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-05-28%20161910.png?raw=true)

## 8. Error Handling

The chatbot handles unknown input safely.

Example:

```
User: asdfghj

Bot: I am not sure I understand. Can you try rephrasing?
```

This prevents crashes and improves user experience.

---

# Technologies Used

## Programming Language

* C#

## Framework

* .NET Windows Forms (WinForms)

## Libraries Used

* System.Collections.Generic
* System.Media
* System.Windows.Forms

---

# Project Structure

## BotApp.cs

Handles:

* GUI interaction
* Button click events
* Displaying messages
* Playing voice greeting

---

## CyberBot.cs

Handles:

* Chatbot logic
* Sentiment detection
* Memory and recall
* Conversation flow
* Keyword recognition

---

## ResponseManager.cs

Handles:

* Definitions
* Random cybersecurity tips
* Dictionaries and Lists

---

## Voice.cs

Handles:

* WAV audio playback

---

# Setup Instructions

## Step 1 – Open the Project

Open the solution in:

```
Visual Studio 2022
```

---

## Step 2 – Restore Packages

Allow Visual Studio to restore project dependencies automatically.

---

## Step 3 – Add WAV File

Create a folder named:

```
Assets
```

Inside the project.

Add:

```
Greeting.wav
```

Example path:

```
ChatBot/Assets/Greeting.wav
```

---

## Step 4 – Build the Project

In Visual Studio:

```
Build > Build Solution
```

Shortcut:

```
Ctrl + Shift + B
```

---

## Step 5 – Run the Project

Press:

```
F5
```

or click:

```text
Start
```

---

# How to Use the Application

## Starting the Bot

When the application starts:

1. The voice greeting plays
2. The bot asks for the user's name
3. The chatbot welcomes the user

Example:

```
Hello John! Welcome to the Cybersecurity Awareness Bot.
Feel free to ask me anything about passwords, scams, privacy or phishing.
```

---

# Example Commands

## Asking About Passwords

```
Tell me about passwords
```

---

## Asking for Definitions

```
What is phishing?
```

```
Define privacy
```

---

## Asking for More Information

```
Tell me more
```

```
Another tip
```

---

## Saving Favourite Topic

```
My favourite topic is phishing
```

---

## Recall Favourite Topic

```
What is my favourite topic?
```

---

## Recall User Name

```
What is my name?
```

---

## Sentiment Detection

```
I am worried
```

```
I am frustrated
```

```
I am curious
```

---

## Exit Conversation

```
Bye
```

Output:

```
Goodbye John! Stay safe online.
```

---

# Object-Oriented Programming Concepts Used

## Classes

* BotApp
* CyberBot
* ResponseManager
* Voice

---

## Methods

Examples:

```
GetResponse()
GetRandomTip()
PlayVoiceGreeting()
SetUserName()
```

---

## Encapsulation

Variables such as:

```
userName
favouriteTopic
```

are stored inside classes and controlled using methods.

---

## Collections

The project uses:

* Dictionary
* List

Example:

```
Dictionary<string, List<string>>
```

---

# Conclusion

The Cybersecurity Awareness Bot successfully demonstrates:

* GUI development
* Cybersecurity education
* Sentiment detection
* Memory and recall
* Dynamic responses
* Conversation flow
* Object-Oriented Programming

The chatbot provides an engaging and beginner friendly way for users to learn cybersecurity awareness.
