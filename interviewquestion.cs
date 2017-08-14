using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2
{
	public class interviewquestion1
	{
		int i = 121;
		List<int> duplicates = new List<int>();
		public void t(int i)
		{



			while (i > 0)
			{
				int lastdigits = i % 10;
				bool isexits = duplicates.Exists(x => x == lastdigits);
				if (isexits == false)
				{
					duplicates.Add(lastdigits);
					i = i / 10;
				}
				else
				{
					Console.WriteLine("duplicates");
					i = i / 10;
				}
			}



		}
	}

	public class interviewquestion2
	{
		 

		List<int> _list = new List<int>() { 0,1};
		List<string> _list1 = new List<string>() { "a","b","c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
		public void method()
		{
			for (int i = 2; i <= 25; i++)
			{
				int new_number = _list[i-2] + _list[i - 1];
				_list.Add(new_number);
				
			}

			string Str = string.Empty;
			Str = "ram";
			int Length = 0;
			int finalsum = 0;
			Length = Str.Length - 1;            //storing the length of given string

			while (Length >= 0)                //loops the given string length
			{
				string Revstr = "";
				Revstr = Revstr + Str[Length];  //performimg a reverse string according to length of given string
				Length--;

				int index = _list1.IndexOf(Revstr);

				finalsum = finalsum + _list[index];


			}
			Console.WriteLine(finalsum);
		}
	}

	
}
