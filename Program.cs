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

			//Node n = new Node();
			//BinaryTreeInsertion nums = new BinaryTreeInsertion();
			//nums.Insert(1);
			//nums.Insert(2);
			//nums.Insert(3);
			//nums.Insert(4);
			//nums.Insert(5);

			//Unbalancesbst nums = new Unbalancesbst();
			//nums.Insert(1);
			//nums.Insert(2);
			//nums.Insert(3);
			//nums.Insert(4);
			//nums.Insert(5);

			BinaryTree b = new BinaryTree();
			b.insert(1);
			b.insert(2);
			b.insert(3);
			b.insert(4);
			b.insert(5);
			b.insert(6);
			b.insert(7);
			b.insert(8);
			b.insert(9);
			b.insert(10);
			b.insert(11);
			Console.WriteLine("The Inorder Traversal:\n");
			b.inOrderTraversal();
			Console.WriteLine("\n\nThe Preorder Traversal:\n");
			b.preOrderTraversal();
			Console.WriteLine("\n\nThe Postorder Traversal:\n");
			b.postOrderTraversal();
			Console.WriteLine();
			Console.WriteLine("Deepak singh");
			Console.ReadKey();
		}



	}





}


