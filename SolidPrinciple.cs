using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class SolidPrinciple
	{
		//s=Single responsibilty Principle.
		//o=open closed principle. 
		//l=Liskov subsitution principle
		//i=interface segregation principle.
		//d=dependency inversion principle.

		



		#region S
		// Single responsibilty Principle :-"There should never be more than one reason for a class to change"
		#region problem
		public void pAdd()
		{
			try
			{
				// Database code goes here
			}
			catch (Exception ex)
			{
				System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
			}
		}
		#endregion

		#region Solutions
		private FileLogger obj = new FileLogger();
		public void sAdd()
		{
			try
			{
				// Database code goes here
			}
			catch (Exception ex)
			{
				obj.Handle(ex.ToString());
			}
		}
		#endregion

		#endregion
		#region o
		#region Problem
		private int _CustType;

		public int CustType
		{
			get { return _CustType; }
			set { _CustType = value; }
		}

		public double getDiscount(double TotalSales)
		{
			if (_CustType == 1)
			{
				return TotalSales - 100;
			}
			else
			{
				return TotalSales - 50;
			}
			
		}
		#endregion
		#region solution
		//See below
		#endregion
		#endregion
	}
	class FileLogger
	{
		public void Handle(string error)
		{
			System.IO.File.WriteAllText(@"c:\Error.txt", error);
		}
	}

	#region o
	class Customer
	{
		public virtual double getDiscount(double TotalSales)
		{
			return TotalSales;
		}
	}
	class SilverCustomer : Customer
	{
		public override double getDiscount(double TotalSales)
		{
			return base.getDiscount(TotalSales) - 50;
		}
	}
	class goldCustomer : SilverCustomer
	{
		public override double getDiscount(double TotalSales)
		{
			return base.getDiscount(TotalSales) - 100;
		}
	}
	#endregion
}
