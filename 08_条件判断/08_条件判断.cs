/*
 条件判断

 用到条件判断的有：
 if 语句
 switch 语句
 ?: 运算符
*/

 using System;

 public class Program
 {
 	static void Main(string[] args)
 	{
 		int a = 3;
 		float f = 3.14f;

 		string res;

 		res = a > f ? "a > f" : "a <= f";

 		Console.Write(res);

 		Console.ReadKey();
 	}
 }