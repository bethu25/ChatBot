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
# Part 3 - Advanced Features

This section expands the Cybersecurity Awareness Bot by adding advanced functionality, including task management, database integration, a cybersecurity quiz, NLP simulation, and activity tracking.

# 1. Cybersecurity Task Assistant

## Overview

The chatbot includes a cybersecurity task management system that helps users organise and track important security activities.

Users can create tasks such as:

* Enable two-factor authentication
* Update passwords
* Review privacy settings
* Check account security

---

## Database Integration

MySQL is used to permanently store cybersecurity tasks.

### Database

```
CyberBotDB
```

### Table

```
Tasks
```

### Database Fields

| Column       | Description            |
| ------------ | ---------------------- |
| TaskID       | Unique task identifier |
| Title        | Task name              |
| Description  | Task details           |
| ReminderDate | Task reminder date     |
| Completed    | Task completion status |

---

## Example Task
![image alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-06-26%20150726.png?raw=true)

---

## Task Management Functions

Users can:

* Add tasks
* View tasks
* Delete tasks
* Mark tasks as completed

### Example
![image alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-06-26%20144203.png?raw=true)

![image alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-06-26%20143937.png?raw=true)

![image alt](https://github.com/bethu25/ChatBot/blob/master/Screenshot%202026-06-26%20143947.png?raw=true)
 
---

# 2. Cybersecurity Mini Game Quiz

## Overview

The chatbot contains an interactive cybersecurity quiz designed to test the user's cybersecurity knowledge.

## Features

The quiz includes:

* 10 cybersecurity questions
* Multiple choice answers
* Score tracking
* Immediate feedback
* Final score display

## Topics Covered

* Phishing
* Password safety
* Malware
* Privacy
* Social engineering

---

## Example Question

```
What makes a strong password?
```

Options:

```
A) Your birthday

B) Password123

C) Letters numbers and symbols
```

Answer:

```
C
```

Feedback:

```
Correct! Strong passwords improve security.
```

---

# 3. Natural Language Processing (NLP) Simulation

## Overview

The chatbot uses a basic NLP simulation system to understand different user commands.

The chatbot recognises user requests using:

* String manipulation
* Keyword detection
* Contains() matching

---

## Examples

User:

```
Remind me to update my password
```

Bot:

```
I can help you create a cybersecurity task.
Open the Task Assistant tab.
```

User:

```
Show my tasks
```

Bot:

```
You can view your saved cybersecurity tasks
in the Task Assistant tab.
```

---

# 4. Activity Log Feature

## Overview

The chatbot records important actions performed during the user's interaction.

## The Activity Log Stores:

* Tasks added
* Tasks completed
* Quiz started
* Quiz completed
* NLP commands recognised

---

## Example

Activity Log:

```
1. Task added: Enable 2FA

2. Quiz completed score 8/10

3. Task marked completed
```

Users can review recent chatbot activity through the Activity Log tab.

---

# Technologies Used

## Programming Language

```
C#
```

## Framework

```
.NET Windows Forms
```

## Database

```
MySQL
```

## Libraries

```
System.Collections.Generic

System.Media

System.Windows.Forms

MySql.Data
```

---

# Project Structure

## BotApp.cs

Responsible for:

* GUI controls
* Button events
* Displaying conversations
* Connecting all features together

---

## CyberBot.cs

Responsible for:

* Chatbot logic
* Keyword recognition
* NLP simulation
* Memory
* Sentiment detection

---

## ResponseManager.cs

Responsible for:

* Cybersecurity definitions
* Security tips
* Random responses

---

## TaskManager.cs

Responsible for:

* Adding tasks
* Viewing tasks
* Deleting tasks
* Completing tasks
* MySQL communication

---

## QuizManager.cs

Responsible for:

* Quiz questions
* Answer options
* Score calculation

---

## ActivityLogger.cs

Responsible for:

* Recording chatbot actions
* Displaying activity history

---

## DatabaseConnection.cs

Responsible for:

* Connecting the C# application with MySQL

---

# Setup Instructions

## Step 1 - Open Project

Open the project using:

```
Visual Studio 2022
```

---

## Step 2 - Install MySQL Package

Install:

```
MySql.Data
```

Using:

```
NuGet Package Manager
```

---

## Step 3 - Create Database

Run:

```sql
CREATE DATABASE CyberBotDB;
```

Select database:

```sql
USE CyberBotDB;
```

Create table:

```sql
CREATE TABLE Tasks
(
TaskID INT AUTO_INCREMENT PRIMARY KEY,

Title VARCHAR(100),

Description VARCHAR(255),

ReminderDate DATE,

Completed BOOLEAN DEFAULT FALSE
);
```

---

## Step 4 - Add Voice File

Create folder:

```
Assets
```

Add:

```
Greeting.wav
```

---

## Step 5 - Build Solution

Visual Studio:

```
Build
>
Build Solution
```

Shortcut:

```
CTRL + SHIFT + B
```

---

## Step 6 - Run Application

Press:

```
F5
```

---

# How To Use The Application

## Starting The Application

When launched:

1. User enters name
2. Bot remembers the user name
3. Welcome message appears

Example:

```
Hello John!
Welcome to the Cybersecurity Awareness Bot.
```

---

# Example Commands

## Cybersecurity Questions

```
What is phishing?
```

```
Tell me about passwords
```

---

## Memory Commands

```
What is my name?
```

```
What is my favourite topic?
```

---

## Task Assistant

```
Add task
```

```
Show tasks
```

```
Complete task
```

---

## Quiz

Open:

```
Quiz Tab
```

Click:

```
Start Quiz
```

---

## Activity Log

Open:

```
Activity Log Tab
```

---

# Object-Oriented Programming Concepts Used

## Classes

* BotApp
* CyberBot
* ResponseManager
* TaskManager
* QuizManager
* ActivityLogger

---

## Encapsulation

Data is controlled using methods.

Examples:

```
SetUserName()

GetResponse()

AddTask()

CompleteTask()
```

---

## Collections

Used:

```
List

Dictionary
```

---

# Conclusion

The Cybersecurity Awareness Bot demonstrates:

* GUI application development
* Database integration
* Cybersecurity education
* NLP simulation
* Task management
* Quiz interaction
* Activity tracking
* Object-Oriented Programming

The application provides users with an interactive platform to improve cybersecurity awareness and practise safer online behaviour.
