using System;

public sealed class Singleton
{
    // Static member to hold the single instance of the class.
    private static Singleton instance = null;

    // A private constructor to prevent direct instantiation from other classes.
    private Singleton()
    {
        Console.WriteLine("Singleton instance created.");
    }

    // Public static property to provide the global access point to the instance.
    public static Singleton Instance
    {
        get
        {
            // Check if the instance is null. If so, create it.
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    // Example method to demonstrate the singleton's functionality.
    public void ShowMessage()
    {
        Console.WriteLine("Hello from the Singleton instance!");
    }
}

// Example of how to use the Singleton.
public class Program
{
    public static void Main(string[] args)
    {
        // Get the single instance of the Singleton class.
        Singleton s1 = Singleton.Instance;
        s1.ShowMessage();

        // Try to get another instance. It will return the same instance.
        Singleton s2 = Singleton.Instance;
        s2.ShowMessage();

        // Verify that both references point to the same instance.
        if (s1 == s2)
        {
            Console.WriteLine("Both s1 and s2 refer to the same Singleton instance.");
        }
    }
}
