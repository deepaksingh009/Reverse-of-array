using ConsoleApp2.DataStructure.BinaryTree;
using System;
using System.Collections.Generic;
using ConsoleApp2.DesignPattern;
using ConsoleApp2.DesignPattern.Interface;
using ConsoleApp2.DesignPattern.Creational_Pattern.Factory_Pattern;
using ConsoleApp2.DesignPattern.Creational_Pattern;
using ConsoleApp2.Patterns;
namespace ConsoleApp2
{
    public class BinarySearchTree
    {
        static void Main()
        {


            //Node root = null;
            //Node root1 = null;
            //root = new Node(1);
            //root.Left = new Node(2);
            //root.Right = new Node(3);
            //root.Left.Left = new Node(4);
            //root.Left.Right = new Node(5);


            //root1 = new Node(1);
            //root1.Left = new Node(2);
            //root1.Right = new Node(3);
            //root1.Left.Left = new Node(4);
            //root1.Left.Right = new Node(5);


            //BinaryTree tree = new BinaryTree();
            //if (tree.identicalTrees(root, root1))
            //    Console.WriteLine("Both trees are identical");
            //else
            //    Console.WriteLine("Trees are not identical");


            ////TreeTraversaliterating n = new TreeTraversaliterating();
            ////n.postOrderItrOneStack(root);                                           


            //FactoryMethod f = new FactoryMethod();
            //Itestinginterface t = f.getcal(2);
            //int i = t.add();
            //Console.WriteLine(i);




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
     public   Boolean identicalTrees(Node a, Node b)
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





