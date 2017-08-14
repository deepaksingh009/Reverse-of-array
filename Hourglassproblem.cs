using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
  public  class Hourglassproblem
    {
		public void Hourglass()

		{
			var A = new int[6, 6];

			for (var i = 0; i < 6; i++)
			{
				var numList = new string[6];
				numList = Console.ReadLine().Split(' ');
				for (var j = 0; j < 6; j++)
				{
					A[i, j] = Convert.ToInt32(numList[j]);
				}
			}

			//int[,] A = new int[6, 6];

			////read
			//for (int i = 0; i < 6; i++)
			//{
			//	for (int j = 0; j < 6; j++)
			//	{
			//		A[i, j] = int.Parse(Console.ReadLine());
			//	}
			//}

			//Write
			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine();

				for (int j = 0; j < 6; j++)
				{
					Console.Write(A[i, j]);
				}
			}
			int test = 1;
			int start = 0;
			int iterate = 0;
			List<int> sum=new List<int>();
			int totalloop = 0;

			while (totalloop <= 3)
			{


				for (int i = 0; i < test; i++)
				{

					for (int j = 0; j < 4; j++)
					{
						int d = A[start, j] + A[start, j + 1] + A[start, j + 2];
						sum.Add(d);

					}

				}

				start = start + 1;

				for (int i = 0; i < test; i++)
				{

					for (int j = 1; j < 5; j++)
					{
						int d = A[start, j];
						sum[iterate] = sum[iterate] + d;
						iterate++;


					}

				}
				iterate = iterate - 4;
				start = start + 1;
				for (int i = 0; i < test; i++)
				{

					for (int j = 0; j < 4; j++)
					{
						int d = A[start, j] + A[start, j + 1] + A[start, j + 2];
						sum[iterate] = sum[iterate] + d;
						iterate++;


					}

				}
				start = start - 1;
				totalloop = totalloop + 1;

			}


			//var max=(from s in sum select s).

			Console.WriteLine(sum.Max());

		}
	}
}
