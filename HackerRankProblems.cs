using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
  public  class HackerRankProblems
    {
		//aabc abcabc aabbcc
		string str = Console.ReadLine();
		
		public int Count()
		{
			var t = str.Distinct();

			//var c = (from s in t where t == s select s).count();
			
			List<int> intput = new List<int>();
			foreach (var item in t)
			{
				var c = str.Count(x => x == item);
				intput.Add(c);
			}

			var product = intput.Aggregate(1, (acc, val) => acc * val);
			return product;

		}
		
    }
}
