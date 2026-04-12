// ================= CHATBOT ENGINE =================
using System.Buffers;


// Controls the main chatbot execution loop.
// The brains behind the operations

public class ChatbotEngine
{
    // Core system components
    private InputProcessor processor = new InputProcessor();
    private ResponseGenerator generator = new ResponseGenerator();
    private MemoryManager memory = new MemoryManager();
    private VoiceService voice = new VoiceService();
    private Logger logger = new Logger();

    
    /// Starts the chatbot and keeps it running continuously.
    
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== SECURE CYBER BOT ===\n");

        // Infinite loop to keep chatbot its a sad reality it couldnt stop itself even if it wanted to it needs me
        while (true)
        {
            try
            {
                Console.ResetColor();
                Console.Write("You: ");

                // Read user input ,avoids empty stuff , and stores it
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;
                memory.Store(input);

                // Reads your response and thinks
                var result = processor.Analyze(input);
                string response = generator.Generate(result, memory);

                // Standard response my G
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bot: " + response);
                voice.Speak(response);
            }
            catch (Exception ex)
            {
                // Log error and recover without crashing (because we don't want that, and ke Genuis)
                logger.Log(ex.Message);
                Console.WriteLine("System recovered from error.");
            }
        }
    }
}
