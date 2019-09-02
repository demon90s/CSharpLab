using System;
using System.Collections.Generic;
using System.Linq;

public class Entry
{
    static void Main(string[] args)
    {
        Func<int, int, int> getSum = (x, y) => x + y;
        Console.WriteLine("3 + 5 = {0}", getSum(3, 5));         // 8

        // another example
        List<int> numList = new List<int> {1, 2, 3, 4, 5};
        List<int> oddList = numList.Where(n => n % 2 == 1).ToList();
        foreach(int num in oddList)
        {
            Console.Write("{0} ", num);     // 1 3 5
        }
        Console.WriteLine();
    }
}
