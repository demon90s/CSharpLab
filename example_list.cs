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

public class MainEntry {
	static void Main(string[] args) {
		// 创建 list
		List<Badguy> badguy_list = new List<Badguy>();

		// 追加元素
		badguy_list.Add(new Badguy("diwen", 99));
		badguy_list.Add(new Badguy("miemie", 80));

		// 用下标访问
		Console.WriteLine("0 element is: " + badguy_list[0]);
		Console.WriteLine("1 element is: " + badguy_list[1]);

		// 删除
		badguy_list.RemoveAt(0);

		Console.WriteLine("after remove, 0 element is: " + badguy_list[0]);

		// 插入，在0位置之前
		badguy_list.Insert(0, new Badguy("diwen", 99));

		Console.WriteLine("after insert, 0 element is: " + badguy_list[0]);

		// 排序，要求自定义类型实现了 IComparable 的 ComparaTo 接口
		badguy_list.Sort();

		Console.WriteLine("after sort: ");
		Console.WriteLine("0 element is: " + badguy_list[0]);
		Console.WriteLine("1 element is: " + badguy_list[1]);
	}
}