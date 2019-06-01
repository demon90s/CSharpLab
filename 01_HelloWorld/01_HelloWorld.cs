/*
 程序结构
 
 using System; 在程序中包含 System 命名空间。一个程序一般有多个 using 语句。
 namespace HelloWorldApplication {} 是 namespace 声明，里面可以有一系列的类型。
 class HelloWorld {} 是 class 声明。
 Main 是所有 C# 程序的入口点。
 WriteLine 是定义在 System 命名空间中的 Console 类的一个方法，在屏幕上打印内容。
 ReadKey 使得程序等待一个按键动作，防止程序从 Visual Studio .Net 启动后立刻关闭。
*/

using System;

namespace HelloWorldApplication
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
			Console.ReadKey();
		}
	}
}