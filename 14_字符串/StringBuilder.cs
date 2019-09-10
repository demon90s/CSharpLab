using System;
using System.Text;

class Entry
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Hello. ");
        sb.AppendFormat("Wow {0}", "diwen");

        sb.Replace("o", "0");

        Console.WriteLine(sb.ToString());        // Hell0. W0w diwen
    }
}