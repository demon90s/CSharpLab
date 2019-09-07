using System;

public class Entry
{
    static void Main(string[] args)
    {
        double n1 = 10.5;
        double n2 = 15;

        Console.WriteLine("Math.Abs({0})={1}", n1, Math.Abs(n1));    // 10.5
        Console.WriteLine("Math.Ceiling({0})={1}", n1, Math.Ceiling(n1));   // 11
        Console.WriteLine("Math.Floor({0})={1}", n1, Math.Floor(n1));   // 10
        Console.WriteLine("Math.Max({0}, {1})={2}", n1, n2, Math.Max(n1, n2));  // 15
        Console.WriteLine("Math.Min({0}, {1})={2}", n1, n2, Math.Min(n1, n2));  // 10.5
        Console.WriteLine("Math.Pow({0}, 2)={1}", n2, Math.Pow(n2, 2)); // 225
        Console.WriteLine("Math.Sqrt(9)={0}", Math.Sqrt(9));    // 3
    }
}