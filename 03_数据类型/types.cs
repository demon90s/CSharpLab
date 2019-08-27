/*
 数据类型
 
 变量有以下几种类型：
 - 值类型，可以直接分配一个值。它们是从 System.ValueType 中派生的
 - 引用类型，不包含存储在变量中的实际数据，但包含变量的引用。
 - 指针类型
 
 值类型有：bool, byte（8位无符号数）, char（16位 Unicode 字符）, decimal, double, float, int, long, sbyte, short, unit, ulong, ushort
 
 使用 sizeof 运算符获取一个类型的尺寸
 
 内置的引用类型有：object, dynamic 和 string
 
 用户自定义的引用类型有：class, interface, delegate
*/

using System;

namespace Application
{
	class Program
	{
		static void Test_sizeof()
		{
			Console.WriteLine("size of int: {0}", sizeof(int));
		}
		
		static void Test_object()
		{
			/*
			 object 类型是C#通用类型系统中所有类型的终极基类。可以被分配任何其他类型的值。
			 当一个值类型转换为 object 类型时，称为装箱；当一个 object 类型转换为值类型时，称为拆箱。
			*/
			object obj;
			obj = 100; // 这是装箱
			
			Console.WriteLine("obj: {0}", obj);
		}
		
		static void Test_dynamic()
		{
			/*
			 可以存储任何类型的值在动态数据类型中，这些变量的类型检查是在运行时发生的。
			 语法：
			 dynamic <variable_name> = value;
			*/
			
			dynamic d = 20;
			
			Console.WriteLine("d: {0}", d);
		}
		
		static void Test_string()
		{
			string str = "Hello";
			Console.WriteLine("str: {0}", str);
			
			// 字符串前加@符号，将转义字符作为普通字符对待
			string str2 = @"C:\Windows";
			Console.WriteLine("str2: {0}", str2);
			
			// @字符串中可以任意换行，换行符和缩进都包含在字符串内
			string str3 = @"
<config>
	Hello
</config>
";
			Console.WriteLine("str3: {0}", str3);
		}

		static void Test_MaxValue()
		{
			// MaxValue可以获得一种类型的最大值
			// MinValue获得最小值
			int maxint = int.MaxValue;
			Console.WriteLine("maxint: " + maxint.ToString());

			long maxlong = long.MaxValue;
			Console.WriteLine("maxlong: " + maxlong.ToString());

			decimal maxdecimal = decimal.MaxValue;
			Console.WriteLine("maxdecimal: " + maxdecimal.ToString());

			float maxfloat = float.MaxValue;
			Console.WriteLine("maxfloat: " + maxfloat.ToString());
		}
	
		static void Test_var_GetTypeCode()
		{
			// var 使用自动推导类型
			// GetTypeCode 获取类型的名字
			var name = "Diwen"; // a string
			Console.WriteLine("name is a {0}", name.GetTypeCode());
		}

		static void Main(string[] args)
		{
			//Test_sizeof();
			//Test_object();
			//Test_dynamic();
			//Test_string();
			//Test_MaxValue();
			Test_var_GetTypeCode();
			
			Console.ReadKey();
		}
	}
}