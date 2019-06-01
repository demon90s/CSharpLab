/*
 当你定义了一个类时，你定义了一个数据类型的蓝图。这实际上没有定义任何数据，但它定义了类的名称意味着什么，
 也就是说，类的对象由什么组成及在这个对象上可执行什么操作。

 对象是类的实例。

 构成类的方法和变量称为类的成员。

 类的构造函数是类的一个特殊的成员函数，当创建类的新对象时执行。
 构造函数的名称与类的名称完全相同，它没有任何返回类型。

 类的析构函数是类的一个特殊的成员函数，当类的对象超出范围时执行。
 析构函数的名称是在类的名称前加一个~，它不返回值，也不带任何参数。
 析构函数用于释放资源。

 可以使用 static 关键字把类成员定义为静态的。意味着无论类的对象有多少，只有一个静态成员的副本。
*/

using System;

public class MainEntry
{
	// 类的定义
	class Box
	{
		public double length; 	// 长度
		public double breadth;	// 宽度
		public double height;	// 高度
	}

	// 使用类
	static void Test_使用类()
	{
		Box box = new Box();

		box.length = 1;
		box.breadth = 1;
		box.height = 1;

		double volume = box.length * box.breadth * box.height;
		Console.WriteLine("box's volume: {0}", volume);
	}

	// 类的封装
	class Box2
	{
		private double length;
		private double breadth;
		private double height;

		public void SetLength(double len) { length = len; }
		public void SetBreadth(double bre) { breadth = bre; }
		public void SetHeight(double hei) { height = hei; }

		public double GetVolume() { return length * breadth * height; } 
	}

	// 使用封装的类
	static void Test_使用封装的类()
	{
		Box2 box = new Box2();
		box.SetLength(1);
		box.SetBreadth(1);
		box.SetHeight(1);

		Console.WriteLine("box's volume: {0}", box.GetVolume());
	}

	// 类 + 构造函数 + 析构函数
	class Line
	{
		private double length = 0; // 线条长度

		// 默认构造函数，没有任何参数
		public Line()
		{
			Console.WriteLine("创建了Line");
		}

		// 有参构造函数
		public Line(int len)
		{
			length = len;
			Console.WriteLine("创建了Line，长度是：{0}", length);
		}

		// 析构函数
		~Line()
		{
			Console.WriteLine("Line被删除");
		}
	}

	static void Test_类的构造函数和析构函数()
	{
		Line l = new Line();
		Line l2 = new Line(10);
	}

	// 类的静态成员
	class StaticVar
	{
		public static int num;
		public void Count()
		{
			num++;
		}

		static public int GetNum() { return num; }
	}

	static void Test_类的静态成员()
	{
		StaticVar var1 = new StaticVar();
		StaticVar var2 = new StaticVar();
		var1.Count();
		var1.Count();

		Console.WriteLine("Var Num: {0}", StaticVar.GetNum());
	}

	static void Main(string[] args)
	{
		//Test_使用类();
		//Test_使用封装的类();
		//Test_类的构造函数和析构函数();
		Test_类的静态成员();
	}
}