using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Patterns
{
  public  class Patternsclass
    {
        public void Lshapepattern()
        {
            int no = 10;
    
            for (int i = 0; i < no; i++)
            {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
               


            }
        }

        public void Lshapereverse()
        {
            int no = 10;
            int counter = 1;
            for (int i = 0; i < no; i++)
            {

                if (i <= no / 2)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < (no / 2) - counter; j++)
                    {
                        Console.Write("*");
                    }
                    counter++;
                    Console.WriteLine();
                }


            }
        }

        public void LReverse()
        {
            int counter = 1;
            for (int i = 10; i > 0; i--)    
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j != i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            Console.Write("*");
                            
                            
                        }
                        counter++;
                    }
                   
                }
                Console.WriteLine();

            }
        }

    }
}
