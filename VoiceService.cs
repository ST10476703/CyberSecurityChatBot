// ================= VOICE SERVICE =================
using System.Speech.Synthesis;

// Handles text-to-speech functionality using System.Speech. took me some time to figure out how to do this but i got it working and it sounds pretty good ngl.
// i was not paying attention in class .
public class VoiceService
{
    private SpeechSynthesizer synth = new SpeechSynthesizer();
    /// Speaks text asynchronously. 
    public void Speak(string text)
    {
        synth.SpeakAsync(text);
    }
}
