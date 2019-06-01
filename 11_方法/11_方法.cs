/*
 方法

 一个方法是把一些相关的语句组织在一起的一个语句块。

 每一个C#程序至少有一个带有 Main 方法的类。

 定义方法的语法：

 <Access Specifier> <Return Type> <Method Name>(Parameter List)
 {
	Method body
 }

 对于成员函数，用 . 运算符调用，如果是 non-static 的，需要有实例

 参数传递方式有：
 值传递
 引用传递，在类型前加 ref
 输出参数，在类型前加 out ，必须修改参数，否则报错
*/

using System;

namespace App
{
	class Program
	{
		// 接受两个整数值，返回较大的那个
		public int FindMax(int num1, int num2)
		{
			int result;

			if (num1 > num2) result = num1;
			else result = num2;

			return result;
		}

		// 递归方法调用：求数的阶乘
		public int Factorial(int num)
		{
			int result;
			if (num == 1) return 1;

			result = Factorial(num - 1) * num;
			return result;
		}

		// 引用传递：交换两个值
		static public void Swap(ref int a, ref int b)
		{
			int tmp;
			tmp = a;
			a = b;
			b = tmp;
		}

		// 输出参数
		static public void GetValue(out int x)
		{
			Console.Write("Enter value: ");
			x = Convert.ToInt32(Console.ReadLine());
		}
	}

	class MainEntry
	{
		static void Test_FindMax()
		{
			int a = 100;
			int b = 200;
			int ret;
			Program program = new Program();

			ret = program.FindMax(a, b);

			Console.WriteLine(ret);
		}

		static void Test_Factorial()
		{
			Program program = new Program();

			Console.WriteLine("3的阶乘是：{0}", program.Factorial(3));
		}

		static void Test_Swap()
		{
			int a = 100;
			int b = 200;

			Program.Swap(ref a, ref b);

			Console.WriteLine("a: {0}, b: {1}", a, b);
		}

		static void Test_GetValue()
		{
			int x;
			Program.GetValue(out x);

			Console.WriteLine("x: {0}", x);
		}

		static void Main(string[] args)
		{
			//Test_FindMax();
			//Test_Factorial();
			//Test_Swap();
			Test_GetValue();

			Console.ReadKey();
		}
	}
}