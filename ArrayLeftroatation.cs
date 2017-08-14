using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
  public  class ArrayLeftroatation
    {
		public void method(int[] a ,int b)
		{
			
			string s = string.Empty;
			string s1 = string.Empty;
			string s2 = string.Empty;

			foreach (var item in a)
			{
				s += item.ToString() + ',';
			}

			for (int i = 0; i < b-1; i++)
			{
				s1 += s.Substring(0, 1) + ' ' ;
				s = s.Remove(0, 1);

			}
			s2 = s + ' ' + s1;
			Console.WriteLine(s2);



		}

		public void Method2()
		{
			string[] s1 = Console.ReadLine().Split(' ');
			int n = int.Parse(s1[0]);
			int k = int.Parse(s1[1]);

			string[] s = Console.ReadLine().Split(' ');
			int[] array = new int[n];

			////pre-rotation of array method:
			//-----------------------------------Right rotation
			//for (int i = 0; i < n; i++)
			//{
			//	array[(i + k) % n] = int.Parse(s[i]);
			//}

			//------------------------------------Left rotation
			for (int i = 0; i < n; i++)
			{
				array[(i + (n - k)) % n] = int.Parse(s[i]);
				int test = (i + (n - k)) % n;
			}

			for (int i = 0; i < n; i++) { Console.Write(array[i] + " "); }
		}

    }
}
