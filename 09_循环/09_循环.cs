/*
 循环语句有：

 while
 for/foreach
 do ... while

 跳出循环的语句有：
 break
 continue
*/

using System;

public class Program
{
	static void Test_while()
	{
		int i = 0;
		while (i < 10)
		{
			Console.WriteLine("{0}", i++);
		}
	}

	static void Test_for()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("{0}", i);
		}
	}

	static void Test_foreach()
	{
		string[] nameArray = {"Jack", "Tom", "Rose"};

		foreach(string str in nameArray)
		{
			Console.WriteLine(str);
		}
	}

	static void Main(string[] args)
	{
		//Test_while();
		//Test_for();
		Test_foreach();

		Console.ReadKey();
	}
}