/*
 多态性

 多态性意味着函数有多重形式，往往表现为“一个接口，多个功能”。

 多态性可以是静态的或动态的。静态表示在编译时发生，动态表示在运行时发生。

 静态多态性即**函数重载**和**运算符重载**。

 使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该
 抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可以被派生类实现。

 抽象类有一些规则：
 - 不能创建一个抽象类的实例。
 - 不能在一个抽象类的外部声明一个抽象方法。
 - 抽象类不能被声明为 sealed  (即不可继承的类型)

 当有一个定义在类中的函数需要在继承中实现时，可以使用虚方法，使用 virtual 关键字声明。
 对虚方法的调用是运行时发生的。

 动态多态性是通过**抽象类**和**虚方法**实现的。
*/

using System;

public class 测试重载
{
	// 几个重载函数
	public void Print(int i)
	{
		Console.WriteLine("Printing int: {0}", i);
	}

	public void Print(double i)
	{
		Console.WriteLine("Printing double: {0}", i);
	}

	public void Print(string s)
	{
		Console.WriteLine("Printing string: {0}", s);
	}
}

// 测试抽象类
abstract class Shape
{
	public abstract int GetArea();
}

class Rectangle : Shape
{
	private int length;
	private int width;
	public Rectangle(int l = 1, int w = 1)
	{
		length = l;
		width = w;
	}

	public override int GetArea()
	{
		return width * length;
	}
}

// 测试虚函数
class Base
{
	public virtual void Print() { Console.WriteLine("I am Base"); }
}

class Derived : Base
{
	public override void Print() { Console.WriteLine("I am Derived"); }
}

public class MainEntry
{
	static void Test_函数重载()
	{
		测试重载 obj = new 测试重载();
		obj.Print(10);
		obj.Print(3.14);
		obj.Print("Hello");
	}

	static void Test_抽象类()
	{
		Rectangle rect = new Rectangle(3, 4);
		Console.WriteLine("rect area: {0}", rect.GetArea());
	}

	static void Test_虚函数(Base obj)
	{
		obj.Print();
	}

	static void Main(string[] args)
	{
		//Test_函数重载();
		//Test_抽象类();

		{
			Base b = new Base();
			Derived d = new Derived();

			Test_虚函数(b);
			Test_虚函数(d);
		}
	}
}