/*
 结构体

 C#中，结构体是值类型数据结构。它使得一个单一变量

 类和结构有以下几个基本不同点：
 - 类是引用类型，结构是值类型
 - 结构不支持继承
 - 结构不能声明默认的构造函数
*/

using System;

public class MainEntry
{
	// 定义结构体
	struct Books
	{
		public string title;
		public string author;
		public string subject;
		public int book_id;
	}

	// 使用结构体
	static void Test_使用结构体()
	{
		Books book;
		book.title = "C# Programming";
		book.author = "Noob";
		book.subject = "Learning C# right now";
		book.book_id = 556677;

		Console.Write("book: title: {0}, author: {1}, subject: {2}, book_id: {3}",
			book.title, book.author, book.subject, book.book_id);
	}

	static void Main(string[] args)
	{
		Test_使用结构体();
	}
}