/*
 字符串

 更一般的方法是用 string 来声明一个字符串变量。

 创建 string 对象的方法：
 通过指定一个字符串
 通过构造函数
 通过运算符+
 通过调用一个返回字符串的方法
 通过格式化的方法来转换一个值或对象为它的字符串表示形式

 String 有许多方法
*/

using System;

public class MainEntry
{
	static void Test_Other()
	{
		// IsNullOrEmpty
		string foo = "";
		
		if (String.IsNullOrEmpty(foo))
		{
			Console.WriteLine("foo is empty");
		}
		else
		{
			Console.WriteLine("Foo is not empty");
		}

		// Length
		foo = "hello";
		Console.WriteLine("Length of foo={0}", foo.Length);

		// Trim white space
		foo = "   foo   ";
		Console.WriteLine("Trim result: *{0}*", foo.Trim());		// *foo*
	}

	static void Test_foreach_string()
	{
		string foo = "hello";
		foreach(char c in foo)
		{
			Console.WriteLine(c);
		}
	}

	static void Test_字符串初始化()
	{
		// 字符串连接
		string fname, lname;
		fname = "Diwen";
		lname = "Liu";

		string fullname = fname + "." + lname;
		Console.WriteLine("Full name: {0}", fullname);

		// 通过构造函数
		char[] letters = {'h', 'e', 'l', 'l', 'o'};
		string greetings = new string(letters);
		Console.WriteLine("Greetings: {0}", greetings);

		// 方法返回字符串
		string[] sarray = {"Hello", "From", "Tutorials", "Point"};
		string message = String.Join(", ", sarray); // 用, 分隔字符数组
		Console.WriteLine("message: {0}", message);

		// 用于转化值的格式化方法
		DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
		string chat = String.Format("Message send at {0:t} on {0:D}",
			waiting);
		Console.WriteLine("Message: {0}", chat);
	}

	static void Test_比较字符串()
	{
		string str1 = "This is test";
		string str2 = "This is text";

		//if (String.Compare(str1, str2) == 0)
		if (str1.Equals(str2))
		{
			Console.WriteLine(str1 + " and " + str2 + " are equal.");
		}
		else
		{
			Console.WriteLine(str1 + " and " + str2 + " are not equal.");
		}
	}

	static void Test_包含字符串()
	{
		string str = "This is test";
		if (str.Contains("test"))
		{
			Console.WriteLine("The sequence 'test' was found");
		}
		else
		{
			Console.WriteLine("The sequence 'test' was not found");
		}
	}

	static void Test_获取字符串()
	{
		string str = "Last night I dreamt of San Pedro";
		Console.WriteLine(str);
		string substr = str.Substring(23); // 从第23个位置开始截取至末尾，San Pedro
		Console.WriteLine(substr);
	}

	static void Main(string[] args)
	{
		Test_Other();
		//Test_foreach_string();
		//Test_字符串初始化();
		//Test_比较字符串();
		//Test_包含字符串();
		//Test_获取字符串();

		Console.ReadKey();
	}
}
