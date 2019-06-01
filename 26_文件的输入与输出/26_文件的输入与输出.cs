/*
 一个文件是一个存储在磁盘中带有指定名称和目录路径的数据集合。当打开一个文件时，它变成一个流。

 从根本上说，流是通过通信路径传递的字节序列。有两个主要的流：输入流和输出流。

 输入流用于从文件读取数据，输出流用于向文件写入数据。

 IO类。
 System.IO 命名空间中有各种不同的类，用于执行各种文件操作。

 FileStream 类
 用于文件的读写和关闭。
*/

using System;
using System.IO;

public class MainEntry {
	static void Test_读写文件() {
		FileStream f = new FileStream("test.dat",
			FileMode.OpenOrCreate, FileAccess.ReadWrite);

		for (int i = 1; i <= 20; i++) {
			f.WriteByte((byte)i);
		}

		f.Position = 0;

		for (int i = 0; i < 20; i++) {
			Console.WriteLine(f.ReadByte());
		}

		f.Close();
	}

	static void Main(string[] args) {
		Test_读写文件();
	}
}