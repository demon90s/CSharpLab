/*
 异常处理

 异常是在程序执行期间出现的问题。比如尝试除以0

 异常提供了一种把程序控制权从某个部分转移到另一个部分的方式。

 创建用户自定义异常
 也可以定义自己的异常。用户自定义的异常类是派生自 ApplicationException 类。
*/

using System;

// 自定义的异常类
public class TempIsZeroException : ApplicationException {
	public TempIsZeroException(string msg) : base(msg) {

	}
}

public class Temperature
{
	int temp;

	public Temperature(int temp_) {
		if (temp_ == 0) {
			throw (new TempIsZeroException("Zero temperature not valid"));
		}
		else {
			temp = temp_;
		}
	}
}

public class MainEntry
{
	static void Test_捕获异常() {
		try {
			int res;
			int divisor = 0;

			res = 10 / divisor;
		}
		catch (DivideByZeroException e) {
			Console.WriteLine("Exception caught: {0}", e);
		}
		finally {
			// 要执行的语句
			// 不管异常是否被抛出都会执行
			Console.WriteLine("try finally");
		}
	}

	static void Test_自定义异常() {
		try {
			Temperature t = new Temperature(0);			
		}
		catch (TempIsZeroException e) {
			Console.WriteLine("TempIsZeroException: {0}", e.Message);
		}
	}

	static void Main(string[] args) {
		//Test_捕获异常();
		Test_自定义异常();
	}
}