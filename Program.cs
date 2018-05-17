using ConsoleApp2.DataStructure.BinaryTree;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class BinarySearchTree
    {
        static void Main()
        {

            Node root = null;
          
            root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            root.Right.Left = new Node(6);
            root.Right.Right = new Node(7);

            TreeTraversal treeTraversal = new TreeTraversal();
            Console.WriteLine("Inorder");
            treeTraversal.inOrder(root);
            Console.WriteLine("preorder");
            treeTraversal.Preorder(root);
            Console.WriteLine("postorder");
            treeTraversal.PostOrder(root);


            //BinaryTree n = new BinaryTree();
            //n.iterativePreorder(root);
            Console.ReadKey();
        }


    }

   
    public class BinaryTree
    {

        public Node root;

        void iterativePreorder()
        {
            iterativePreorder(root);
        }

        // An iterative process to print preorder traversal of Binary tree
        public void iterativePreorder(Node node)
        {
            if (node == null)
            {
                return;
            }


            Stack<Node> nodeStack = new Stack<Node>();
            nodeStack.Push(node);
            //Node curr = node;
            while (nodeStack.Count > 0)
            {

                Node mynode = nodeStack.Peek();
                Console.WriteLine(mynode.Data + " ");
                nodeStack.Pop();

                // Push right and left children of the popped node to stack
                if (mynode.Right != null)
                {
                    nodeStack.Push(mynode.Right);
                }
                if (mynode.Left != null)
                {
                    nodeStack.Push(mynode.Left);
                }
                //if (curr != null)
                //{

                //    nodeStack.Push(curr);
                //    curr = curr.left;

                //}
                //else
                //{
                //    curr = nodeStack.Pop();
                //    Console.WriteLine(curr.data);
                //    curr = curr.right;


                //}
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





