/*
 交错数组是数组的数组

 声明一个交错数组：
 int [][] scores;
*/

using System;

public class MainEntry
{
	static void Test_交错数组()
	{
		int [][] a = new int[][]{
			new int[]{0, 0}, 
			new int[]{1, 2},
			new int[]{3, 4}
		};

		for (int i = 0; i < a.Length; ++i)
		{
			for (int j = 0; j < a[i].Length; ++j)
			{
				Console.Write("{0} ", a[i][j]);
			}
			Console.WriteLine();
		}
	}

	static void Main(string[] args)
	{
		Test_交错数组();
		Console.ReadKey();
	}
}