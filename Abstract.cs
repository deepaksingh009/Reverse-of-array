using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public abstract class Abstract
	{
		public static int id = 11;
		public virtual void newmethod()
		{

		}
	}
	// we cannot override abstract class variable,can't create instance of  abstract class
	//we just inherit abstract class i.e ,if we have to implement abstract class method,
	//so we can done only by inherit that base class from derive class.

	public class abstactclass : Abstract
	{
		public void m()
		{
			abstactclass obj = new abstactclass();
			obj.newmethod();
			Abstract.id = 10;
			Console.WriteLine(Abstract.id);
		}

	}

	public abstract class _abstact1
	{
		public void Method1()
		{
			Console.WriteLine("Method1");
		}
	}

	public abstract class _abstact2
	{
		public virtual void Method1()
		{
			Console.WriteLine("Method1");
		}
	}

	public class Class1:_abstact2
	{
		public override void Method1()
		{

			Console.WriteLine(" over ride Method1");
		}
	}



}
