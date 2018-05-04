using ConsoleApp2.DesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DesignPattern
{
    public class  FactoryMethod
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


}
