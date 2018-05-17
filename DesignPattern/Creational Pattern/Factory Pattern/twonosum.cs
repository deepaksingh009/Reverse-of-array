using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.DesignPattern.Interface;

namespace ConsoleApp2.DesignPattern.Creational_Pattern.Factory_Pattern
{
  public  class twonosum: Itestinginterface

	{
		public int add()
		{
			return 1 + 2;
		}
    }
	public class Threenosum : Itestinginterface
	{
		public int add()
		{
			return 1 + 2 + 3;
		}
	}
}
