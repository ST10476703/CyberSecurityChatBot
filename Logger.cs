// ================= LOGGER =================
using System.IO;

// Handles logging errors to a file for debugging and tracking .
public class Logger
{
    // Writes error message to log file.
    public void Log(string message)
    {
        File.AppendAllText("log.txt", message + "\n");
    }
}