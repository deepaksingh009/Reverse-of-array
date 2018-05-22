using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DesignPattern.Creational_Pattern.Factory_Method_Design_Pattern
{
	public class FactoryMethodDesignPattern
	{
		
		
	}
	/// <summary>

	/// The 'Product' abstract class

	/// </summary>
	abstract class Transport
	{

	}

	/// <summary>

	/// A 'ConcreteProduct' class

	/// </summary>

	class RoadTransport : Transport

	{
		public RoadTransport()
		{
			Console.WriteLine("RoadTransport");
		}
	}

	/// <summary>

	/// A 'ConcreteProduct' class

	/// </summary>

	class ShipTransport : Transport
	{
		public ShipTransport()
		{
			Console.WriteLine("ShipTransport");
		}
	}



	/// <summary>

	/// The 'Creator' abstract class

	/// </summary>

	abstract class TransportType

	{
		// Factory Method
		public abstract void CreatePages(int i);
	}

	/// <summary>

	/// A 'ConcreteCreator' class

	/// </summary>

	class Resume : TransportType

	{
		// Factory Method implementation

		public override void CreatePages(int i)
		{
			if (i == 1)
			{
				new RoadTransport();
			}
			else
			{
				new ShipTransport();
			}
		}
	}



}
