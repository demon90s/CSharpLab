/*
 变量

 变量是一个供程序操作的存储区的名字。C#中，每个变量都有一个特定的类型。

 定义变量的语法：
 <data_type> <variable_list>;

 可以在定义时初始化变量。也可以延后初始化。
 
*/

 using System;

 public class TestVariable
 {
 	static void Test_Variable_Define()
 	{
 		int i, j;
 		float x = 3.14f;

 		// 初始化	
 		i = 42;
 		j = 100;

 		Console.WriteLine("i: {0}, j: {1}, x: {2}", i, j, x);
 	}

 	// ReadLine 用于接受用户的输入，并把它存入一个变量中
 	static void Test_ReadLine()
 	{
 		int num;
 		num = Convert.ToInt32(Console.ReadLine());

 		Console.WriteLine("num: {0}", num);
 	}

 	static void Main(string[] args)
 	{
 		//Test_Variable_Define();
 		Test_ReadLine();

 		Console.ReadKey();
 	}
 }