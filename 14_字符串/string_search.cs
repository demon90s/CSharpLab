using System;

public class Entry
{
    static void Main(string[] args)
    {
        string foo = "hello world csharp...";

        Console.WriteLine("Index of world={0}", foo.IndexOf("world"));  // 6
        Console.WriteLine("2nd word: {0}", foo.Substring(6, 5));        // world

        Console.WriteLine("Starts with \"hello\"? {0}", foo.StartsWith("hello"));     // True
        Console.WriteLine("Ends with \"csharp\"? {0}", foo.EndsWith("csharp"));     // False
    }
}