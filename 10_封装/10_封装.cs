/*
 封装

 封装通过访问修饰符来实现，一个访问修饰符定义了一个类成员的范围和可见性。
 C#支持的访问修饰符如下：

 public: 所有对象都可以访问
 private: 对象本身在对象内部可以访问
 protected: 只有该类对象及其子类对象可以访问
 internal: 同一个程序集的对象可以访问
 protected internal: 访问限于当前程序集或派生自包含类的类型

 如果没有指定访问修饰符，那么默认为 private
*/

using System;

public class Program
{
	class Rectangle1
	{
		// public 成员变量，外部可以直接访问
		public double length = 1;
		public double width = 1;

		// 访问修饰符默认为 private
		double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("length: {0}", length);
			Console.WriteLine("width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}

	class Rectangle2
	{
		// private 成员变量，外部不可以访问
		private double length;
		private double width;

		public void Acceptdetails()
		{
			Console.Write("请输入长度: ");
			length = Convert.ToDouble(Console.ReadLine());

			Console.Write("请输入宽度: ");
			width = Convert.ToDouble(Console.ReadLine());
		}

		double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("length: {0}", length);
			Console.WriteLine("width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}

	static void Main(string[] args)
	{
		// Rectangle1 r = new Rectangle1();
		// r.length = 4.2;
		// r.width = 5;
		// r.Display();
		
		Rectangle2 r = new Rectangle2();
		r.Acceptdetails();
		r.Display();

		Console.ReadKey();
	}
}