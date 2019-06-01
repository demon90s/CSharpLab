/*
 数组是一个存储相同类型元素的固定大小的顺序集合。
 数组下标从0开始。

 声明数组：
 datatype[] arrayName;
 例如：
 double[] balances;

 初始化数组：
 double[] balances = new double[10];

 使用 for 或者 foreach 循环可以遍历数组每一个元素
*/

using System;

namespace App
{
	class MainEntry
	{
		static void Test_数组初始化()
		{
			double[] balances = new double[10];
			balances[0] = 4500.0;

			double[] balances2 = {4222.0, 3333.0, 1111.0};

			int[] numbers = new int[5]{1, 2, 3, 4, 5};
			int[] score = numbers; // 指向同一个数组

			score[0] = 100;
			Console.Write(numbers[0]);
		}

		static void Test_遍历数组()
		{
			int[] n = new int[10];

			// 初始化
			for (int i = 0; i < 10; i++)
			{
				n[i] = i + 100;
			}

			// 输出每个元素的值
			foreach(int i in n)
			{
				Console.WriteLine("Element[{0}]: {1}", i - 100, i);
			}
		}

		/* 传递数组给函数 */
		static double getAverage(int[] arr, int size)
		{
			int i;
			double avg;
			int sum = 0;

			for (i = 0; i < size; ++i)
			{
				sum += arr[i];
			}

			avg = (double)sum / size;
			return avg;
		}

		/* 参数数组，在参数前加 params */
		static int getSum(params int[] arr)
		{
			int sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			return sum;
		}

		static void Main(string[] args)
		{
			//Test_数组初始化();
			//Test_遍历数组();

			// {
			// 	int [] a = {1, 2, 3, 4, 5, 6};
			// 	Console.WriteLine("{0}", getAverage(a, a.Length));
			// }

			{
				int [] a = {1, 2, 3, 4, 5, 6};
				Console.WriteLine("{0}", getSum(a));
			}
			
			Console.ReadKey();
		}
	}
}