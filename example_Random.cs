using System;

public class Entry
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        Console.WriteLine("random num between 1 and 10: {0}",
            rand.Next(1, 11));
    }
}