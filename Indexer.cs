using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class Indexer
	{
		private string Name { get; set; }
		public string name
		{
			get; set;
		}
		public string sd;
	}
	public class Tests
	{
		Indexer tesr = new Indexer
		{
			sd = "jj",
			name="fd"


		};
		public void metho()
		{

			Console.WriteLine(tesr.sd);
		}
	
	}

}
		
