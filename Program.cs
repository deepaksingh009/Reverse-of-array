using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
       {
			//int n = Convert.ToInt32(Console.ReadLine());
			//string[] arr_temp = Console.ReadLine().Split(' ');



			//int no = int.Parse(Console.ReadLine());
			//int[] array = new int[no];
			//for (int i = 0; i < array.Length; i++)
			//{
			//	array[i] = int.Parse(Console.ReadLine());
			//}

			int n = Convert.ToInt32(Console.ReadLine());
			string[] arr_temp = Console.ReadLine().Split(' ');


			string[] reversearray = new string[n];
			int lenght = arr_temp.Length - 1;
			for (int i = 0; i < arr_temp.Length; i++)
			{

				reversearray[lenght] = arr_temp[i];


				lenght = lenght - 1;
			}

			dynamic final_list = null;
			foreach (var item in reversearray)
			{
				final_list += item + " ";
			}

			Console.WriteLine(final_list);
			Console.ReadLine();




		}
	}
}