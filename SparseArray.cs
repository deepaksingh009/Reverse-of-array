using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public class SparseArray
    {
		public List<string> method1()
		{

			//Console.WriteLine("Enter no of strings");
			int noofstrings = int.Parse( Console.ReadLine());
			//Console.WriteLine("Enter strings");
			List<string> input = new List<string>();
			for (int i = 0; i < noofstrings; i++)
			{
				string str = Console.ReadLine();
				input.Add(str);

			}

			//Console.WriteLine("Enter no of Queries");
			int noofqueries = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Queries");
			List<string> Queries = new List<string>();
			for (int i = 0; i < noofqueries; i++)
			{
				string str = Console.ReadLine();
				Queries.Add(str);

			}
			var totalno = "";
			for (int i = 0; i < noofqueries; i++)
			{
				var no = 0;
				for (int j = 0; j < noofstrings; j++)
				{
					string strtocheck = Queries[i];

					if (input[j] == Queries[i])
					{
						no++;
					}
				}
				totalno = totalno + "," + no;
			}

			string[] split = totalno.Split(',');

			for (int i = 1; i <= split.Length; i++)
			{
				Console.WriteLine(split[i]);
			} 

			return input;

		}
    }
}
