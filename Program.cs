using ConsoleApp2.DataStructure.BinaryTree;
using System;

namespace ConsoleApp2
{
    public class BinarySearchTree
    {
        static void Main()
        {
            MorriseInordertreetraversal tree = new MorriseInordertreetraversal();
            tree.root = new tNode(1);
            tree.root.left = new tNode(2);
            tree.root.right = new tNode(3);
            tree.root.left.left = new tNode(4);

            tree.root.left.right = new tNode(5);

            tree.root.right.left = new tNode(6);

            tree.root.right.right = new tNode(7);


            //tree.root.left.left.left = new tNode(8);
            //tree.root.left.left.right = new tNode(9);

            //tree.root.left.right.left = new tNode(10);
            //tree.root.left.right.right = new tNode(11);

            //tree.root.right.left.left = new tNode(12);
            //tree.root.right.left.right = new tNode(13);

            //tree.root.right.right.left = new tNode(14);
            //tree.root.right.right.right = new tNode(15);

            BinarySearchTree consoleApp2 = new BinarySearchTree();
            consoleApp2.inOrder(tree.root);

            Console.WriteLine();
            Console.ReadKey();



           


        }

        private void inOrder(tNode node)
        {
            if (node == null)
            {
                return;
            }

            
            inOrder(node.left);
            Console.WriteLine(node.data);
            inOrder(node.right);
        }
    }

   

    public class BinaryTree
    {

        // Java program to find height of tree

        // A binary tree node
        //public class Nodes
        //{
        //    public int data;
        //    public Nodes left, right;

        //    public Nodes(int item)
        //    {
        //        data = item;
        //        left = right = null;
        //    }
        //}

        //public class BinaryTrees
        //{
        //    public Nodes root;

        //    /* Compute the "maxDepth" of a tree -- the number of 
        //       nodes along the longest path from the root node 
        //       down to the farthest leaf node.*/
        //    public int maxDepth(Nodes node)
        //    {
        //        if (node == null)
        //            return 0;
        //        else
        //        {
        //            /* compute the depth of each subtree */
        //            int lDepth = maxDepth(node.left);
        //            int rDepth = maxDepth(node.right);

        //            /* use the larger one */
        //            if (lDepth > rDepth)
        //                return (lDepth + 1);
        //            else
        //                return (rDepth + 1);
        //        }
        //    }
        //}
    }

 

    


}





