﻿using ConsoleApp2.DesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DesignPattern
{
    public class FactoryMethod
    {
        public Itestinginterface getcal(int i)
        {
            Itestinginterface returnvalue = null;
            if (i == 1)
            {
                returnvalue = new Calculator();
            }
            else
            {
                returnvalue = new Calculator();
            }

            return returnvalue;
        }
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

    abstract class Document

    {
        // Factory Method
        public abstract void CreatePages(int i);
    }

    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>

    class Resume : Document

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

    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>

    //class Report : Document

    //{
    //    // Factory Method implementation

    //    public override void CreatePages()
    //    {
    //        Pages.Add(new IntroductionPage());
    //        Pages.Add(new ResultsPage());
    //        Pages.Add(new ConclusionPage());
    //        Pages.Add(new SummaryPage());
    //        Pages.Add(new BibliographyPage());
    //    }
    //}

}

#region MainImplementation
///<summary>
///Abstract implenation
///</summary>

//Resume resume = new Resume();
//resume.CreatePages(1);
//            resume.CreatePages(2);

///<summary>
///Interface implenation
///</summary>
//FactoryMethod factoryMethod = new FactoryMethod();
//Itestinginterface itestinginterface = factoryMethod.getcal(1);
//int i = itestinginterface.add();
//int j = itestinginterface.subtract();



#endregion