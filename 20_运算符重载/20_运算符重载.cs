/*
 运算符重载

 重载运算符是具有特殊名称的函数，通过关键字 operator 后跟运算符的符号来定义。

 有的运算符可以被重载，有的不能。
*/

using System;

public class MainEntry
{
	// 重载运算符实例
	class Box
	{
		private double length; 	// 长度
		private double breadth;	// 宽度
		private double height;	// 高度

		public Box(int l = 1, int b = 1, int h = 1)
		{
			length = l;
			breadth = b;
			height = h;
		}

		// 重载 + 运算符把两个 Box 对象相加
		public static Box operator+(Box b, Box c)
		{
			Box box = new Box();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}

		public double GetVolume()
		{
			return length * breadth * height;
		}
	}

	static void 测试重载运算符()
	{
		Box a_box = new Box(1, 1, 1);
		Box b_box = new Box(2, 2, 2);
		Box c_box = new Box();

		c_box = a_box + b_box;

		Console.WriteLine("c_box volume: {0}", c_box.GetVolume());
	}

	static void Main(string[] args)
	{
		测试重载运算符();
	}
}