/*
 get set
*/

using System;
using System.Collections;

public class Foo {

	public int MyInt
	{
		get {
			Console.WriteLine("getcall");
			return my_int;
		}

		set {
			Console.WriteLine("setcall");
			my_int = value;
		}
	}

	private int my_int;
}

public class MainEntry {
	static void Main(string[] args) {
		Foo f = new Foo();
		f.MyInt = 10; // call set

		Console.WriteLine("f: " + f.MyInt); // call get
	}
}