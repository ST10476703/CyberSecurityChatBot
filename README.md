
# Cyber Security Chatbot — Part 1

## Overview
This project is a C# console-based chatbot designed to educate users about cybersecurity threats and best practices. It simulates a digital assistant that provides structured responses based on user input.

---

## Objective
To build a chatbot that:
- Interacts with users
- Identifies cybersecurity topics
- Provides relevant advice
- Maintains a stable and structured system

---

## Features Implemented

- Keyword-based topic detection
- Structured response generation
- Multiple cybersecurity topics supported
- User name capture and personalization
- ASCII-based interface
- WAV audio greeting
- Error handling using try-catch
- Logging system for debugging

---

## System Architecture

The system is divided into multiple components:

- ChatbotEngine → controls program flow
- InputProcessor → analyzes user input
- ResponseGenerator → generates responses
- MemoryManager → stores interaction data
- VoiceService → handles audio output
- Logger → logs system errors

## How to Run

1. Open project in Visual Studio
2. Ensure:
   - Target Framework = net8.0-windows
3. Add welcome.wav file:
   - Build Action = Content
   - Copy to Output Directory = Copy if newer
4. Build the project (Ctrl + Shift + B)
5. Run the application (F5)

## Challenges Faced

- Integrating audio using System.Media
- Managing multiple classes in one project
- Fixing namespace and reference errors
- Ensuring system stability under all inputs

---

## Limitations

- Uses keyword matching (no advanced NLP)
- Limited response variation
- No multi-topic handling yet
- Basic interaction logic

---

## Future Improvements (Part 2)

- Multi-topic detection
- Intent classification
- Adaptive response system
- Scenario simulation
- Quiz functionality

# Cyber Intelligence System (CIS) v3.0
**PROG6221 - Portfolio of Evidence (Part 3)**

## Overview
The Cyber Intelligence System is a modular C# Windows Forms desktop application developed to educate users on cybersecurity best practices. Transitioning from a foundational command-line interface into a decoupled graphical desktop environment, this platform features an NLP-driven chatbot, a dynamic multi-format assessment game, a secure SQLite-backed Task Assistant, and a paginated activity logging system.

## Key Features
* **Decoupled GUI Architecture:** Utilizes a central routing shell (`MainForm`) that dynamically swaps functional `UserControls`, ensuring strict Object-Oriented separation of visual layouts and processing logic.
* **Advanced NLP Chat Engine:** Abandons basic string matching for a robust Regular Expression (Regex) dictionary, accurately detecting over 20 distinct cybersecurity intents. .
* **Voice Accessibility:** Integrates asynchronous Text-to-Speech (`System.Speech.Synthesis`) to read chatbot responses aloud without freezing the main UI thread.
* **Task Assistant (SQLite):** A fully integrated relational database tier executing secure, parameterized CRUD operations for user tasks, complete with an asynchronous background reminder system.
* **Interactive Cyber Quiz:** A dynamic 20-question assessment engine that programmatically adapts its interface (e.g., hiding unused buttons for True/False inputs) at runtime to provide specialized educational feedback.
* **Paginated System Logs:** Centralized tracking of internal actions (NLP intercepts, logins, database writes) into a local `log.txt` file, displayed through a custom LINQ-driven 8-line pagination UI.

## Prerequisites
To compile and run this application, ensure your environment meets the following requirements:
* **Operating System:** Windows 10 or higher.
* **IDE:** Microsoft Visual Studio 2022 (or newer).
* **Framework:** .NET SDK (Compatible with Windows Forms).
* **Dependencies:** `Microsoft.Data.Sqlite` (Available via NuGet).

## Setup & Installation Instructions
1. **Clone the Repository:**
   Open your terminal or Git Bash and run:
   ```bash
   git clone <your-github-repository-url-here>
## Author
ofentse
