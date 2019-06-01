/*
 delegate

 函数的代理
*/

using System;

public class MainEntry {

	delegate void MyDelegate(int num);

	static void Main(string[] args) {
		MyDelegate my_delegate;

		my_delegate = PrintNum;
		my_delegate(50);

		my_delegate += PrintDoubleNum;
		my_delegate(50); // 现在会调用两个函数
	}

	static void PrintNum(int num) {
		Console.WriteLine("PrintNum: " + num);
	}

	static void PrintDoubleNum(int num) {
		Console.WriteLine("PrintDoubleNum: " + num * 2);
	}
}