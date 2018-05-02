using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
 public  class MajorityNumberinlist
    {
		public void Method()
		{
			int noinlist = int.Parse(Console.ReadLine());
			var list = new string[noinlist];
			  list = Console.ReadLine().Split(' ');
			List<Distinctlist> distinctlist = new List<Distinctlist>();
			var DistinctNumber = (from s in list select s).Distinct().ToList();
			foreach (var item in DistinctNumber)
			{
				Distinctlist obj = new Distinctlist();
				obj.Number = Convert.ToInt32(item);
				distinctlist.Add(obj);
			}

			foreach (var item in list)
			{
				int item1 = Convert.ToInt32(item);
				var no = (from s in distinctlist where s.Number == item1 select s.CountNumber).First();
				no = no+1;
				distinctlist.Where(w => w.Number == item1).ToList().ForEach(i => i.CountNumber = no);
			}

			var max = (from s in distinctlist select s).OrderByDescending(x => x.CountNumber).First();
			Console.WriteLine(max.Number);

		}

		public class Distinctlist
		{
			public int Number { get; set; }
			public int CountNumber { get; set; }

		}
	}
}
