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
            int no = 3;
            for (int i = no; i > 0; i--)    
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j != i-1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        for (int k = 1; k <= counter; k++)
                        {
                            Console.Write(k);
                        }
                        for (int f = 1; f < counter; f++)
                        {
                            Console.Write(f);
                        }
                        counter++;
                    }
                }
                Console.WriteLine();

            }
          counter = 1;
            for (int i = 3; i > 0; i--)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= i-1; k++)
                {
                    Console.Write(k);
                }

                for (int k = counter; k > 0; k--)
                {
                    Console.Write(k);
                }
                counter++;

                Console.WriteLine();

            }
        }

        public void ReversePyramid()
        {
            int counter = 1;
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < i-1; k++)
                {
                    Console.Write("*");
                }
                counter++;

                Console.WriteLine();

            }
        }

    }
}
