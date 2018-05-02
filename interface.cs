using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public interface INterfacetutorial
	{
		void method1(int q,int b);
	}

	//public void m()
	//{
	//	maths arr = new maths();
	//	arr.x = 0;
	//	arr.cal(2);
	//	maths1 obj = new maths1();
	//	i1 i = (i1)obj;
	//	i.fun();
	//	i2 ii = (i2)obj;
	//	ii.fun();
	//	Console.WriteLine(arr.x);
	//}
	interface IMyInterface
	{
		void fun1();
		int fun2();
	}
	public  class t : IMyInterface
	{
		public void fun1()
		{
			Console.WriteLine("e");
		}
		 int IMyInterface.fun2()
		{
			int i = 5;
			Console.WriteLine(i);
			return i;
		}

	}
	interface i1 
	{
		void fun();
	}
	interface i2
	{
		void fun();
	}
	public class maths1 : i1, i2
	{
		void i1.fun()
		{
			Console.WriteLine("i1.fun");
		}
		void i2.fun()
		{
			Console.WriteLine("i2.fun");
		}
	}
	interface calc
	{
		void cal(int i);
	}
	public class maths : calc
	{
		public int x;
		public void cal(int i)
		{
			x = i * i;
		}
	}


}
