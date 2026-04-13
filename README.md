
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


## Author
ofentse
