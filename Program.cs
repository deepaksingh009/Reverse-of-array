using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.DataStructure;
using ConsoleApp2.DataStructure.BinaryTree;
using Itenso.TimePeriod;
using static ConsoleApp2.Delegatess;

namespace ConsoleApp2
{
	public class BinarySearchTree
	{
		static void Main()
		{

			Node n = new Node();
			BinaryTreeInsertion nums = new BinaryTreeInsertion();
			nums.Insert(50);
			nums.Insert(17);
			n = nums.Insert(54);

			//nums.Insert(12);
			//nums.Insert(19);
			//nums.Insert(54);
			//nums.Insert(9);
			//nums.Insert(14);
			//nums.Insert(67);
			//nums.Insert(76);
			//nums.Insert(1);
			BinaryTreeDeletion deletion = new BinaryTreeDeletion();
			deletion.Delete(n,17);
			Console.WriteLine("Deepak singh");
			Console.ReadKey();
		}



	}





}


