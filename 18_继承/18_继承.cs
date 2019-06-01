/*
 继承

 一个类可以派生自多个类或接口。

 派生类继承了基类的成员变量和成员方法。因此父类对象应在子类对象创建之前被创建。

 C#不支持多重继承，但可以使用接口来实现多重继承。

*/

using System;

public class MainEntry
{
	// 基类 Shape
	class Shape
	{
		public Shape() { width = 1; height = 1; }
		public Shape(int w, int h) { width = w; height = h; }

		public void SetWidth(int w) { width = w; }
		public void SetHeigth(int h) { height = h; } 

		protected int width;
		protected int height;
	}

	// 派生类 Rectangle
	class Rectangle : Shape
	{
		public Rectangle() {}
		public Rectangle(int w, int h) : base(w, h) {}

		public int GetArea() { return width * height; }
	}

	// 接口类，可应用于实现多重继承
	public interface ShapeInterface
	{
		double GetArea();
	}

	// 多重继承
	class Circle : Shape, ShapeInterface
	{
		public Circle() {}
		public Circle(int w, int h) : base(0, 0) {}
		public Circle(int r) { radius = r; }

		public double GetArea() { return radius * radius * 3.14; }

		private int radius;
	}

	static void Test_Rectangle()
	{
		Rectangle rect = new Rectangle();
		rect.SetWidth(2);
		rect.SetHeigth(3);

		Console.WriteLine("rect Area: {0}", rect.GetArea());

		Rectangle rect2 = new Rectangle(10, 20);
		Console.WriteLine("rect2 Area: {0}", rect2.GetArea());
	}

	static void Test_Circle()
	{
		Circle circle = new Circle(10);

		Console.WriteLine("circle area: {0}", circle.GetArea());
	}

	static void Main(string[] args)
	{
		//Test_Rectangle();
		Test_Circle();
	}
}