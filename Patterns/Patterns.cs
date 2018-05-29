using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Patterns
{
    public class Patternsclass
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
            int no = 6;
            for (int i = no; i > 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j != i - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        for (int k = 1; k <= counter; k++)
                        {
                            if (k == 2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(k);
                            }
                        }
                        for (int f = counter - 1; f >= 1; f--)
                        {

                            if (f == 2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(f);
                            }
                        }
                        counter++;
                    }
                }
                Console.WriteLine();

            }
            counter = 1;
            for (int i = no; i > 0; i--)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k < i - 1; k++)
                {
                    if (k == 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(k);
                    }
                }

                for (int k = i - 1; k > 0; k--)
                {
                    if (k == 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(k);
                    }
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
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k);
                }

                for (int f = i; f > 0; f--)
                {
                    Console.Write(f);
                }
                counter++;

                Console.WriteLine();

            }
        }

    }
}

//Implementation
//            Patternsclass patterns = new Patternsclass();
//patterns.Lshapepattern();
//            patterns.Lshapereverse();
//            patterns.LReverse();
//            patterns.ReversePyramid();