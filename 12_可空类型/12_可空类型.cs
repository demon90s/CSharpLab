/*
 可空类型

 C#提供了一种特殊的数据类型， nullable 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再多加一个 null 值。
 比如，Nullable<Int32> ，读作可空的Int32，除了正常的Int32取值，还有一个可取值null。

 声明一个 nullable 类型的语法：
 <data_type> ? <variable_name> = null;

 Null 合并运算符 ??
 如：num ?? 3
 如果 如：num 为 null ，那么返回 3 ，否则返回 num
*/

using System;

namespace App
{
	class MainEntry
	{
		static void Test_Nullable()
		{
			int? num1 = null;
			int? num2 = 45;
			double? num3 = new double?();
			double? num4 = 3.14;

			bool? boolVal = new bool?();

			// 显示值
			Console.WriteLine("显示可空类型的值：{0}, {1}, {2}, {3}", num1, num2, num3, num4);
			Console.WriteLine("一个可空的布尔值：{0}", boolVal);
		}

		static void Test_合并运算符()
		{
			int? num1 = null;
			int? num2 = 3;

			Console.WriteLine("num1: {0}", num1 ?? 1000);
			Console.WriteLine("num2: {0}", num2 ?? 1000);
		}

		static void Main(string[] args)
		{
			//Test_Nullable();
			Test_合并运算符();

			Console.ReadKey();
		}
	}
}