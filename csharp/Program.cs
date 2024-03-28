using System.Diagnostics;

internal class Program
{
    private static void WriteLine(string message) 
    {
        string result = $"[{DateTime.Now.ToShortDateString()} {DateTime.Now.ToString("HH:mm:ss")}] {message}";
        Console.WriteLine(result);
    }

    private static void Main(string[] args)
    {
        WriteLine("Starting...");

        // Execute a function/action/procedure:
        // ...

        WriteLine("End of Program");
    }
}