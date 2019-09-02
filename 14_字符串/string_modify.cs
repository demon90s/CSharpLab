using System;

public class Entry
{
    static void Main(string[] args)
    {
        string foo = "hello world";

        Console.WriteLine("replace result: {0}", foo.Replace("o", "0"));        // hell0 w0rld

        // foo没有被修改
        Console.WriteLine("foo: {0}", foo); // hello world

        Console.WriteLine("remove result: *{0}*", foo.Remove(0, 5));          // * world*

        Console.WriteLine("fmt result: {0}", String.Format("{0:c}", 100));      // $100.00  
        Console.WriteLine("fmt result: {0}", String.Format("{0:00.00}", 3.14));  // 03.14
        Console.WriteLine("fmt result: {0}", String.Format("{0:0,0}", 12000));    // 12,000

        // split
        foo = "one|two|three";
        string[] str_arr = foo.Split("|");
        foreach (string str in str_arr)
        {
            Console.Write(" " + str);       // one two three
        }
        Console.WriteLine();
    }
}
