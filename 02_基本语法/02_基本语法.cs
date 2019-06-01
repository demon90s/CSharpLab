/*
 基本语法
 
 using 关键字用于在程序中包含命名空间
 class 关键字用于声明一个类
 
*/

using System;

namespace RectangleApplication
{
	class Rectangle
	{
		// 成员变量
		double length;
		double width;
		
		// 成员函数
		public void Acceptdetails()
		{
			length = 4.5;
			width = 3.5;
		}
		
		public double GetArea()
		{
			return length * width;
		}
		
		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}
	
	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			// 实例化一个类型对象
			Rectangle r = new Rectangle();
			r.Acceptdetails();
			r.Display();
			Console.ReadLine();
		}
	}
}