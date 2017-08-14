using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
			#region reverseofarray
			//int n = Convert.ToInt32(Console.ReadLine());
			//string[] arr_temp = Console.ReadLine().Split(' ');


			//string[] reversearray = new string[n];
			//int lenght = arr_temp.Length - 1;
			//for (int i = 0; i < arr_temp.Length; i++)
			//{

			//	reversearray[lenght] = arr_temp[i];


			//	lenght = lenght - 1;
			//}

			//dynamic final_list = null;
			//foreach (var item in reversearray)
			//{
			//	final_list += item + " ";
			//}

			//Console.WriteLine(final_list);
			//

			#endregion



			//Tests n = new Tests();
			//n.metho();
			//Console.ReadLine();

			//string test = "deepak";
			//string test1 = "dee";
			//if (test.Contains(test1))
			//{
			//	Console.WriteLine("don");
			//	Console.ReadLine();

			//}


			//interviewquestion1 obj = new interviewquestion1();
			//obj.t(121);

			//interviewquestion2 obj1 = new interviewquestion2();
			//obj1.method();


			//var numbers = new int[3, 3];

			//for (var i = 0; i < 3; i++)
			//{
			//	var numList = new string[3];
			//	numList = Console.ReadLine().Split(' ');
			//	for (var j = 0; j < 3; j++)
			//	{
			//		numbers[i, j] = Convert.ToInt32(numList[j]);
			//	}
			//}

			Hourglassproblem obj = new Hourglassproblem();
			obj.Hourglass();

			Console.ReadLine();


		}
	}



}