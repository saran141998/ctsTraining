using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programFive
{
	class Program
	{
		static void Main(string[] args)
		{
		
			List<int> a1 = new List<int>() { 4,4,2,5,5,5,5,3,3,2,1};
	        ArrayList a2=new ArrayList();
			SortedDictionary<int, int> sd = new SortedDictionary<int, int>();
			foreach(var g in a1.GroupBy(i => i))
			{
				sd.Add(g.Key, g.Count());
			}
		foreach(KeyValuePair<int,int> k in sd)
			{
				for(int i = 0; i < k.Value; i++)
				{
					Console.Write(k.Key);
				}
			//	Console.WriteLine("Key:{0} Value:{1}",k.Key,k.Value);
			}
			Console.ReadKey();		
		}
	}
}
