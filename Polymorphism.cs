using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
  public static class Polymorphism
    {

	static Polymorphism()
		{

		}

		public static int method(int a,int b)
		{
			
			return a + b;
		}

		public static string method(string a, string b,string c)
		{
			return a + b;
		}

		
    }
	public  class poly
	{
		public  int b { get; set; }

		public int methods(int a, int b)
		{
			this.b = b;
			return a * b;
		}
	}



	
}
