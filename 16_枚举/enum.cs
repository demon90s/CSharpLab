/*
 枚举

 枚举是一组命名整型常量。枚举类型是使用 enum 关键字声明的。
 C#枚举是值类型。
*/

using System;

public class MainEntry
{
	// 声明 enum 变量，默认第一个枚举符号的值是0
	enum Days
	{
		Sun, Mon, Tue, Wed, Thu, Fri, Sat
	}

	// 使用枚举
	static void Test_使用枚举()
	{
		Days d;
		d = Days.Mon;

		Console.WriteLine("Monday: {0}, value: {1}", d, (int)d);
	}

	static void Main(string[] args)
	{
		Test_使用枚举();
	}
}