// ================= PROGRAM.CS =================
using System;

// i actually forgot to add main program file until the end but here it is. This is the entry point of the application and it initializes the chatbot engine and starts the interaction loop. It's pretty straightforward, just creating an instance of ChatbotEngine and calling Start() to begin the conversation with the user.


class Program
{
    static void Main()
    {
        // Create chatbot instance
        ChatbotEngine bot = new ChatbotEngine();

        // Start chatbot loop
        bot.Start();
    }
}