using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public abstract class Abstract
	{
		public virtual void newmethod()
		{

		}
	}
	public class abstactclass:Abstract
	{
		public void m()
		{
			abstactclass obj = new abstactclass();
			obj.newmethod();
		}
	}
}
