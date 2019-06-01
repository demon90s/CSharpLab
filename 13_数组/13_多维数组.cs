/*
 这样声明一个 string 类型的二维数组：
 string [,] names;

 声明一个三维数组：
 int [ , , ] m;

 二维数组可以被认为是一个行列矩阵。
*/

using System;

public class MainEntry
{
	static void Test_初始化二维数组()
	{
		int [,] a = new int[3, 4] {
			{0, 1, 2, 3},
			{4, 5, 6, 7},
			{8, 9, 10, 11},
		};

		for (int i = 0; i < 3; ++i) {
			for (int j = 0; j < 4; ++j) {
				Console.Write("{0} ", a[i, j]);
			}
			Console.WriteLine();
		}
	}

	static void Main(string[] args)
	{
		Test_初始化二维数组();
		Console.ReadKey();
	}
}