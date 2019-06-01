/*
 正则表达式

 正则表达式是一种匹配输入文本的模式。
*/

using System;
using System.Text.RegularExpressions;

public class MainEntry
{
	static void Main(string[] args) {
		string input = "1851 1999 1950 1905 2003";
		string pattern = @"(?<=19)\d{2}\b";

		foreach (Match match in Regex.Matches(input, pattern))
			Console.WriteLine(match.Value);
	}
}