using ConsoleApp2.DataStructure.BinaryTree;
using System;
using System.Collections.Generic;
using ConsoleApp2.DesignPattern;
using ConsoleApp2.DesignPattern.Interface;
using ConsoleApp2.DesignPattern.Creational_Pattern.Factory_Pattern;

namespace ConsoleApp2
{
    public class BinarySearchTree
    {
        static void Main()
        {

            //Node root = null;

            //root = new Node(1);
            //root.Left = new Node(2);
            //root.Right = new Node(3);
            //root.Left.Left = new Node(4);
            //root.Left.Right = new Node(5);
            //root.Right.Left = new Node(6);
            //root.Right.Right = new Node(7);

            ////TreeTraversaliterating n = new TreeTraversaliterating();
            ////n.postOrderItrOneStack(root);

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.levelorderinsertion();

            //FactoryMethod f = new FactoryMethod();
            //Itestinginterface t = f.getcal(2);
            //int i = t.add();
            //Console.WriteLine(i);

            Console.ReadKey();
        }


    }


    public class BinaryTree
    {

        public void levelorderinsertion()
        {
            Node binarytree;
            int count = 0;
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11 };
            Node nodes = new Node();
            nodes.Data = list[count];
            list.RemoveAt(count);

            Queue<Node> Queenodes = new Queue<Node>();
            binarytree = nodes;
            Node current;
            Node test = binarytree;
            int lastindex = list.Count - 1;
            while (list.Count > 0)
            {
                current = test;


                if (test.Left == null)
                {
                    Node d = new Node();
                    d.Data = list[count];
                    list.RemoveAt(count);
                  //  count++;
                    test.Left = d;
                    Queenodes.Enqueue(d);


                }
                if (test.Right == null)
                {
                    Node s = new Node();
                    s.Data = list[count];
                    list.RemoveAt(count);
                  //  count--;
                    test.Right = s;
                    Queenodes.Enqueue(s);
                   
                }
                if (test.Left != null && test.Right != null)
                {
                    test = Queenodes.Dequeue();

                }




            }



        }


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





