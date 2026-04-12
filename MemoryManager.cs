// ================= MEMORY MANAGER =================//
using System.Collections.Generic;

// Tracks user interaction history and topic frequency.
// Enables adaptive chatbot responses so it seams alive and stuff.

public class MemoryManager
{
    // Tracks how many times each topic was discussed
    private Dictionary<string, int> topicCount = new Dictionary<string, int>();

    // Stores user input (can be expanded for deeper context tracking).
    
    public void Store(string input)
    {
        // Placeholder for future enhancements (context tracking) trust me i know what i'm doing i hope
    }

    
    // Returns interaction level for a topic , to determine response complexity.
    
    public int GetInteractionLevel(string topic)
    {
        if (!topicCount.ContainsKey(topic)) topicCount[topic] = 0;

        topicCount[topic]++;
        return topicCount[topic];
    }
}
