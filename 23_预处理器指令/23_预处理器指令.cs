/*
 预处理器指令

 预处理器指令编译器在编译开始之前对信息进行预处理。

 所有的预处理器指令都是以#开始。

 在C#中，预处理器指令用于条件编译，不用于创建宏。

 #define 预处理器
 用于创建符号常量，这样，通过使用符号作为传递给#if指令的表达式，表达式将返回 true
 #define sysbol

 条件指令
 可以使用#if创建一个条件指令，用于判断测试符号是否为真，如果是，那么执行下面的代码
 可以用 && 和 || 连接条件
*/

//#define
#define PI

using System;

public class MainEntry
{
	static void Main(string[] args) {
		#if(PI)
			Console.WriteLine("PI is defined");
		#else
			Console.WriteLine("PI is not defined");
		#endif
	}
}