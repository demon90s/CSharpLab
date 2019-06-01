/*
 运算符有：

 算术运算符：+ - * / % ++ --
 关系运算符：== != > < >= <=
 逻辑运算符：&& || !
 位运算符：& | ^ ~ << >>
 赋值运算符：= += -= ...
 其他运算符：sizeof typeof &(取地址) *(解引用) ?: is as

 运算符有优先级，一元最高，赋值和逗号最低。
 运算符还有结合性。
*/

using System;

namespace Operators
{
	class Program
	{
		static void 算术运算符()
		{
			int a = 21;
			int b = 10;
			int c;

			c = a + b;
			Console.WriteLine("{0}", c);

			c = a - b;
			Console.WriteLine("{0}", c);

			c = a * b;
			Console.WriteLine("{0}", c);

			c = a / b;
			Console.WriteLine("{0}", c);

			c = a % b;
			Console.WriteLine("{0}", c);
		}

		static void 关系运算符()
		{
			int a = 21;
			int b = 10;

			if (a > b)
			{
				Console.WriteLine("a > b");
			}
			else
			{
				Console.WriteLine("a < b");
			}
		}

		/* 输出变量类型的名字 */
		static void Test_typeof()
		{
			Console.WriteLine("typeof int: {0}", typeof(int));
			Console.WriteLine("typeof this class: {0}", typeof(Program));
		}

		static void Main(string[] args)
		{
			//算术运算符();
			//关系运算符();
			Test_typeof();

			Console.Write("请按任意键继续...");
			Console.ReadKey();
		}
	}
}