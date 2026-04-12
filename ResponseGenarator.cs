// ================= RESPONSE GENERATOR =================

using System.Buffers;



// Generates chatbot responses based on detected topic and user interaction history(this stuff is custom.
// Supports adaptive responses (beginner → advanced) "next level i know ".
public class ResponseGenerator
{
    
    /// Generate response using topic and memory context.
    // trust the process line 15 was before i added the memory manager so it should be fine

    public string Generate(string topic, MemoryManager memory)
    {
        // Determine how many times user has asked about this topic
        int level = memory.GetInteractionLevel(topic);

        switch (topic)
        {
            case "phishing":
                return level == 1 ?
                    "Phishing is a fake message attack. Always verify links i can't stress this enough. What signs would you check?" :
                    "Pro Tip (i know what i'm talking about): Inspect email headers and domains to detect phishing.";

            case "malware":
                return level == 1 ?
                    "Malware damages systems. Avoid unknown downloads." :
                    "Pro Tip (i know what i'm talking about): Use sandboxing to analyze suspicious files.";

            case "password":
                return "Use long, unique passwords. Consider a password manager.";

            default:
                return "Threat detected: " + topic + ". Stay alert.";
        }
    }
}