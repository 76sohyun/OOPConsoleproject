namespace OOPConsoleproject;

public static class Extension
{
   
}

public static class Utill
{
    public static void PressAnyKey(string text)
    {
        Console.WriteLine(text);
        Console.WriteLine("계속하려면 아무키나 누르세요...");
        Console.ReadKey(true);
    }
}