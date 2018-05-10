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
using ConsoleApp2.DesignPattern;
using ConsoleApp2.DesignPattern.Interface;
using Itenso.TimePeriod;
using static ConsoleApp2.Delegatess;

namespace ConsoleApp2
{
    public class BinarySearchTree
    {
        static void Main()
        {



            //Unbalancesbst nums = new Unbalancesbst();
            //nums.Insert(1);
            //nums.Insert(2);
            //nums.Insert(3);
            //nums.Insert(4);
            //nums.Insert(5);

            //BinaryTree b = new BinaryTree();
            //b.insert(1);
            //b.insert(2);
            //b.insert(3);
            //b.insert(4);
            //b.insert(5);
            //b.insert(6);
            //b.insert(7);
            //b.insert(8);
            //b.insert(9);

            //BinaryTree c = new BinaryTree();
            //c.insert(1);
            //c.insert(2);
            //c.insert(3);
            //c.insert(4);
            //c.insert(5);
            //c.insert(6);
            //c.insert(7);
            //c.insert(8);
            //c.insert(9);





            //b.insert(10);
            //b.insert(11);
            //b.insert(12);
            //b.insert(13);
            //Console.WriteLine("The Inorder Traversal:\n");
            //b.inOrderTraversal();
            //Console.WriteLine("\n\nThe Preorder Traversal:\n");
            //b.preOrderTraversal();
            //Console.WriteLine("\n\nThe Postorder Traversal:\n");
            //b.postOrderTraversal();
            //Console.WriteLine();
            //Console.WriteLine("Deepak singh");
            //Console.ReadKey();




            BinaryTrees tree = new BinaryTrees();

            tree.root = new Nodes(1);
            tree.root.left = new Nodes(2);
            tree.root.right = new Nodes(3);
            tree.root.left.left = new Nodes(4);
            tree.root.left.right = new Nodes(5);
            Console.WriteLine(tree.maxDepth(tree.root));

            Console.ReadKey();


        }



    }
    // Java program to find height of tree

    // A binary tree node
    public class Nodes
    {
        public int data;
        public Nodes left, right;

        public Nodes(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public class BinaryTrees
    {
        public Nodes root;

        /* Compute the "maxDepth" of a tree -- the number of 
           nodes along the longest path from the root node 
           down to the farthest leaf node.*/
        public int maxDepth(Nodes node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.left);
                int rDepth = maxDepth(node.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
    }
}








