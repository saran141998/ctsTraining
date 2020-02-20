﻿using System;
using System.Linq;
using System.IO;
namespace directoryInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo dInfo = new DirectoryInfo(@"D:/vs2017");
			long sizeOfDir = DirectorySize(dInfo, true);
			Console.WriteLine("Directory size in Bytes : " +
			"{0:N0} Bytes", sizeOfDir);
			Console.WriteLine("Directory size in KB : " +
			"{0:N2} KB", ((double)sizeOfDir) / 1024);
			Console.WriteLine("Directory size in MB : " +
			"{0:N2} MB", ((double)sizeOfDir) / (1024 * 1024));
			Console.ReadLine();
		}
		static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
		{
			long totalSize = dInfo.EnumerateFiles()
						 .Sum(file => file.Length);
			if (includeSubDir)
			{
				totalSize += dInfo.EnumerateDirectories()
						 .Sum(dir => DirectorySize(dir, true));
			}
			return totalSize;
		}
	}
}