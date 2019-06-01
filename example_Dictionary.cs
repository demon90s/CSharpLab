/*
 Dictionary

 key-value 的泛型容器。

 https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?redirectedfrom=MSDN&view=netframework-4.7.2
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
		// 定义一个 Dictionary
		Dictionary<string, Badguy> badguys = new Dictionary<string, Badguy>();

		// 添加元素
		Badguy bg1 = new Badguy("liudiwen", 88);
		Badguy bg2 = new Badguy("miemie", 90);

		badguys.Add("liudiwen", bg1);
		badguys.Add("miemie", bg2);

		// 访问
		// 若使用下标，则要保证 key 存在
		// 或使用 TryGetValue 方法
		//Console.WriteLine(badguys["qqqq"]); // exception invoke
		Console.WriteLine(badguys["liudiwen"]);

		Badguy tmp = null;
		if (badguys.TryGetValue("miemie", out tmp)) {
			Console.WriteLine(tmp);
		}
		else {
			Console.WriteLine("no miemie");
		}
	}
}