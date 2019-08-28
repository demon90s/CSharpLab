/*
 接口interface

 接口定义了所有类继承接口时应遵循的语法合同。

 接口定义语法合同是什么，派生类定义语法合同怎么做。

 接口只包括成员的声明，成员的定义是派生类的责任。
*/

using System;

// 定义接口
// 接口声明默认是 public 的
interface IMyInterface
{
	void MethodToImplement();
}

// 接口实现
class InterfaceImplementer : IMyInterface
{
	public void MethodToImplement()
	{
		Console.WriteLine("MethodToImplement called");
	}
}

public class MainEntry
{
	static void Main(string[] args)
	{
		InterfaceImplementer impl = new InterfaceImplementer();
		impl.MethodToImplement();
	}
}