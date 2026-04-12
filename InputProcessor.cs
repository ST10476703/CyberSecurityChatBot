// ================= INPUT PROCESSOR =================
using System;
using System.Collections.Generic;
using System.Linq;


/// looks for input and identifying cybersecurity topics.
/// Uses keyword matching and scoring system (we all make mistakes so this should help).

public class InputProcessor
{
    // Dictionary mapping topics to related keywords tbh i got this online 
    private Dictionary<string, string[]> topicKeywords = new Dictionary<string, string[]>
    {
        {"phishing", new[]{"phishing","email scam","fake email"}},
        {"malware", new[]{"malware","virus","trojan"}},
        {"ransomware", new[]{"ransomware","locked files"}},
        {"password", new[]{"password","credentials"}},
        {"2fa", new[]{"2fa","two factor"}},
        {"vpn", new[]{"vpn","private network"}},
        {"encryption", new[]{"encryption","encrypt"}},
        {"firewall", new[]{"firewall"}},
        {"social", new[]{"social engineering"}},
        {"ddos", new[]{"ddos","traffic attack"}},
        {"botnet", new[]{"botnet"}},
        {"spyware", new[]{"spyware"}},
        {"databreach", new[]{"data breach"}},
        {"identity", new[]{"identity theft"}},
        {"zero-day", new[]{"zero day"}}
    };

    
    // checks our input and returns the most relevant topic (hopefully).
    
    public string Analyze(string input)
    {
        input = input.ToLower();

        // Store scores for each topic
        var scores = new Dictionary<string, int>();

        // Calculates scores based on keyword matches (the more matches, the higher the score , i think)
        foreach (var topic in topicKeywords)
        {
            int score = topic.Value.Count(k => input.Contains(k));
            scores[topic.Key] = score;
        }

        // Return topic with highest score
        return scores.OrderByDescending(x => x.Value).First().Key;
    }
}
