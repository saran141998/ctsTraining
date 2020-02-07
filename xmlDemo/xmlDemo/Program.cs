using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlDocument xd= new XmlDocument();
			xd.Load(@"D:\csharp\sample.xml");
			XmlNodeList xl = xd.GetElementsByTagName("price");

			XmlElement e = xd.GetElementById("bk101");
			Console.WriteLine();
			for(int i=0;i< xl.Count;i++)
			{
				Console.WriteLine(xl[i].InnerXml);
			}

			//XmlNode currentNode = xd.DocumentElement.FirstChild;
			//Console.WriteLine(currentNode.OuterXml);
			//XmlNode nextNode = currentNode.NextSibling;
			//Console.WriteLine(nextNode.OuterXml);
			//XmlNode node3 = nextNode.NextSibling;
			//Console.WriteLine(node3.OuterXml);
			Console.ReadKey();
		}
	}
}
