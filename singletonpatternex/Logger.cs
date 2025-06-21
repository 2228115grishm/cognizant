public sealed class Logger
{
    // Private static instance (lazy initialization)
    private static readonly Lazy<Logger> _instance = 
        new Lazy<Logger>(() => new Logger());

    // Private constructor
    private Logger() 
    {
        Console.WriteLine("Logger instance created");
    }

    // Public access point
    public static Logger Instance => _instance.Value;

    // Log method for demonstration
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
