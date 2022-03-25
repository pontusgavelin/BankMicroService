namespace LoggerService.Logger;

public class Logger : ILogger
{
    public string resultingLogmessage = "";
    public void log(string message)
    {
        if (message.Length > 200)
        {
            var truncatedMessage = message.Substring(0, 200);
            resultingLogmessage = truncatedMessage;
            Console.WriteLine($"Message logged: {truncatedMessage}");
        }
        else
        {
            Console.Write($"Message logged: {message}");
        }

    }
}