using System;

public class Entry
{
    static void Main(string[] args)
    {
        string[] names = new string[3] { "liudiwen", "limeili", "liuyiya" };
        
        Console.WriteLine("names: {0}", String.Join("|", names));   // liudiwen|limeili|liuyiya
    }
}