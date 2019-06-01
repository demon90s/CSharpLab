/*
 命名空间

 命名空间设计的目的是提供一种让一组名称与其他名称分隔开的方式。

 定义命名空间的方式：
 namespace namespace_name
 {
	// 代码
 }

 使用命名空间中的名字：
 namespace_name.item_name

 using 关键字
 using 关键字表明程序使用的是给定命名空间中的名称。
 比如使用了 System 命名空间后， Console 实际上是 System.Console

 命名空间可以嵌套。
*/

using System;

namespace first_space
{
	class Foo
	{
		public void Print()
		{
			Console.WriteLine("Hi, I am first_space.Foo");
		}
	}
}

public class App
{
	static void Main(string[] args)
	{
		first_space.Foo foo = new first_space.Foo();
		foo.Print();
	}
}