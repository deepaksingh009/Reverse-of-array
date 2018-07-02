using ConsoleApp2.DataStructure.BinaryTree;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class BinarySearchTree
    {
		private LinkedList<int> adjLists;
		//void start()
		//{
		//	long[] a1 = { 3, 4, 5 };
		//	long[] a2 = fix(a1);
		//	Console.WriteLine(a1[0] + a1[1] + a1[2] + " ");
		//	Console.WriteLine(a2[0] + a2[1] + a2[2]);
		//}

		//long[] fix(long[] a3)
		//{
		//	a3[1] = 7;
		//	return a3;
		//}
		static void Main()
        {
			var tune = new LinkedList<string>();
			tune.AddFirst("do"); // do
			tune.AddLast("so"); // do - so
			tune.AddAfter(tune.First, "re"); // do - re- so
			tune.AddAfter(tune.First.Next, "mi"); // do - re - mi- so
			tune.AddBefore(tune.Last, "fa"); // do - re - mi - fa- so
			tune.RemoveFirst(); // re - mi - fa - so
			tune.RemoveLast(); // re - mi - fa
			LinkedListNode<string> miNode = tune.Find("mi");
			tune.Remove(miNode); // re - fa
			tune.AddFirst(miNode); // mi- re - fa
			foreach (string s in tune) Console.WriteLine(s);
			
			//Node root = new Node(1);
			//root.Left = new Node(2);
			//root.Right = new Node(3);
			//root.Left.Left = new Node(4);
			//root.Left.Right = new Node(5);
			//root.Left.Left.Left = new Node(6);
			//Printtopview t = new Printtopview(root);
			//t.TopView();





			//// Create and run the African animal world

			//ContinentFactory africa = new AfricaFactory();
			//AnimalWorld world = new AnimalWorld(africa);
			//world.RunFoodChain();

			//// Create and run the American animal world

			//ContinentFactory america = new AmericaFactory();
			//world = new AnimalWorld(america);
			//world.RunFoodChain();

			//// Wait for user input

			Console.ReadKey();

        }


    }


    public class BinaryTree
    {




        /* Given two trees, return true if they are
           structurally identical */
        public Boolean identicalTrees(Node a, Node b)
        {
            /*1. both empty */
            if (a == null && b == null)
                return true;

            /* 2. both non-empty -> compare them */
            if (a != null && b != null)
                return (a.Data == b.Data && identicalTrees(a.Left, b.Left) && identicalTrees(a.Right, b.Right));

            /* 3. one empty, one not -> false */
            return false;
        }

        /* Driver program to test identicalTrees() function */

        //public class BinaryTree
        //{

        //    // Java program to find height of tree

        //    // A binary tree node
        //    //public class Nodes
        //    //{
        //    //    public int data;
        //    //    public Nodes left, right;

        //    //    public Nodes(int item)
        //    //    {
        //    //        data = item;
        //    //        left = right = null;
        //    //    }
        //    //}

        //    //public class BinaryTrees
        //    //{
        //    //    public Nodes root;

        //    //    /* Compute the "maxDepth" of a tree -- the number of 
        //    //       nodes along the longest path from the root node 
        //    //       down to the farthest leaf node.*/
        //    //    public int maxDepth(Nodes node)
        //    //    {
        //    //        if (node == null)
        //    //            return 0;
        //    //        else
        //    //        {
        //    //            /* compute the depth of each subtree */
        //    //            int lDepth = maxDepth(node.left);
        //    //            int rDepth = maxDepth(node.right);

        //    //            /* use the larger one */
        //    //            if (lDepth > rDepth)
        //    //                return (lDepth + 1);
        //    //            else
        //    //                return (rDepth + 1);
        //    //        }
        //    //    }
        //    //}
        //}






    }


}





