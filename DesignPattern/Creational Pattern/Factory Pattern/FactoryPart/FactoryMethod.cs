using ConsoleApp2.DesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.DesignPattern.Creational_Pattern.Factory_Pattern;

namespace ConsoleApp2.DesignPattern
{
    public class FactoryMethod
    {
        public Itestinginterface getcal(int i)
        {
            Itestinginterface returnvalue = null;
            if (i == 1)
            {
                returnvalue = new twonosum();
            }
            else
            {
                returnvalue = new Threenosum();
            }

            return returnvalue;
        }
    }




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



//FactoryMethod f = new FactoryMethod();
//Itestinginterface t = f.getcal(2);
//int i = t.add();
//Console.WriteLine(i);

#endregion