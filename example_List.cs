/*
 List 是泛型容器，它可以动态增长。
 使用它需要包含命名空间 System.Collections.Generic

 https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=netframework-4.7.2
*/

using System;
using System.Collections.Generic;

public class Badguy : IComparable<Badguy> {
	public string name;
	public int power;

	public Badguy(string _name, int _power) {
		name = _name;
		power = _power;
	}

	public override string ToString() {
		return "(" + name + ", " + power.ToString() + ")";
	}

	public int CompareTo(Badguy other) {
		if (other == null) {
			return 1;
		}
		return power - other.power;
	}
}

public class MainEntry
{
	static void Print(List<int> ilist)
	{
		Console.Write("List: ");
		for (int i = 0; i < ilist.Count; i++)
		{
			Console.Write("{0} ", ilist[i]);
		}
		Console.WriteLine();
	}

	static void Test()
	{
		List<int> ilist = new List<int>();

		// 添加元素
		ilist.Add(42);
		ilist.Add(100);
		Print(ilist);			// 42 100

		int[] arr = new int[3] {1, 2, 3};
		ilist.AddRange(arr);
		Print(ilist);			// 42 100 1 2 3

		// 清空元素
		ilist.Clear();
		Print(ilist);			// 

		// Insert(index, value)
		ilist.Insert(0, 666);
		ilist.Insert(0, 111);
		Print(ilist);			// 111 666

		// RemoveAt(index) Remove(value)
		ilist.Remove(111);
		Print(ilist);			// 666

		ilist.RemoveAt(0);
		Print(ilist);			// 

		// IndexOf(value)
		ilist = new List<int>(new int[]{5, 3, 1});
		Console.WriteLine("IndexOf(3)={0}", ilist.IndexOf(3));	// 1

		// Contains(value)
		Console.WriteLine("Contains(2)? {0}", ilist.Contains(2));	// False

		// Sort
		ilist.Sort();
		Print(ilist);			// 1 3 5
	}

	static void TestCustom()
	{
		// 创建 list
		List<Badguy> badguy_list = new List<Badguy>();

		// 追加元素
		badguy_list.Add(new Badguy("diwen", 99));
		badguy_list.Add(new Badguy("miemie", 80));

		// 用下标访问
		Console.WriteLine("0 element is: " + badguy_list[0]);			// diwen
		Console.WriteLine("1 element is: " + badguy_list[1]);			// miemie

		// 删除
		badguy_list.RemoveAt(0);

		Console.WriteLine("after remove, 0 element is: " + badguy_list[0]);	// miemie

		// 插入，在0位置之前
		badguy_list.Insert(0, new Badguy("diwen", 99));

		Console.WriteLine("after insert, 0 element is: " + badguy_list[0]);	// diwen

		// 排序，要求自定义类型实现了 IComparable 的 ComparaTo 接口
		badguy_list.Sort();

		Console.WriteLine("after sort: ");
		Console.WriteLine("0 element is: " + badguy_list[0]);	// miemie
		Console.WriteLine("1 element is: " + badguy_list[1]);	// diwen
	}

	static void Main(string[] args)
	{
		Test();
		//TestCustom();
	}
}