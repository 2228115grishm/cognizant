// See https://aka.ms/new-console-template for more information
// Logger.cs
// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Test singleton behavior
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        // Verify single instance
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
        
        // Test logging
        logger1.Log("First log message");
        logger2.Log("Second log message");
        
        // Attempt to create new instance (will fail)
        // Logger logger3 = new Logger(); // Compile error
    }
}