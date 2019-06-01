/*
 Array 类

 Array 类是C#中所有数组的基类，它是在 System 命名空间中定义的。 
 Array 类提供了各种用于数组的属性和方法。

 常用属性：
 - IsFixedSize - 获取一个值，该值指示数组是否带有固定大小
 - IsReadOnly - 获取一个值，该值表示数组是否只读
 - Length - 获取一个32位整数，该值表示所有维度的数组中的元素的总数
 - Rank - 获取数组的秩（维度）

*/

using System;

public class MainEntry
{
	static void Main(string[] args)
	{
		int[] list = {34, 72, 13, 44, 25, 30, 10};

		Console.Write("原始数组: ");
		foreach (int i in list)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();

		// 逆转数组
		Array.Reverse(list);
		Console.Write("逆转数组: ");
		foreach (int i in list)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();

		// 排序数组
		Array.Sort(list);
		Console.Write("排序数组: ");
		foreach (int i in list)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();

		Console.ReadKey();
	}
}