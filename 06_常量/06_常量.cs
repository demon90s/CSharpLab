/*
 常量

 常量是固定值，程序执行期间不会改变。

 整数常量，如：
 212
 215U
 0xFE
 077

 浮点常量，如：
 3.14
 314E-2

 字符常量，如：
 'x'
 '\n'

 字符串常量，如：
 "Hello"

 定义常量：
 const <data_type> <const_name> = value;
*/

using System;

public class ConstantTest
{
	static void Test_Constant()
	{
		const double pi = 3.14;
		double r;
		Console.WriteLine("Enter Radius: ");
		r = Convert.ToDouble(Console.ReadLine());
		double areaCircle = pi * r * r;
		Console.WriteLine("Raduis: {0}, Area: {1}", r, areaCircle);
	}

	static void Main(string[] args)
	{
		Test_Constant();

		Console.ReadKey();
	}
}