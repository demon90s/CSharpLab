/*
 类型转换有两种：

 - 隐式转换：以安全的方式转换，不会导致数据丢失。例如，从小整数转换为大整数，从派生类转换为基类。
 - 显式转换：需要强制转换运算符，会造成数据丢失。

 C# 提供了内置类型转换的方法，比如 ToString ，将内置类型转换成 string
*/

 using System;

 namespace TypeConvertApplication
 {
 	class ConversionTest
 	{
 		// 强制类型转换
 		static void Test_ExplicitConversion()
 		{
 			double d = 3.14;
 			int i;

 			// 强制转换 double 为 int
 			i = (int)d;
 			Console.WriteLine("i: {0}", i);
 		}

 		static void Test_ToString()
 		{
 			bool b = true;

 			Console.WriteLine("b({0}) to string is: {1}", b, b.ToString());
 		}

 		static void Main(string[] args)
 		{
 			//Test_ExplicitConversion();
 			Test_ToString();

 			Console.ReadKey();
 		}
 	}
 }