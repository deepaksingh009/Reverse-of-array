using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class TreeTraversaliterating
    {
        public Node root;
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

       
                if (mynode.Right != null)
                {
                    nodeStack.Push(mynode.Right);
                }
                if (mynode.Left != null)
                {
                    nodeStack.Push(mynode.Left);
                }
               
            }



        }

        public void inorderItr(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            Node node = root;
            while (true)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }
                else
                {
                    if (stack.Count <= 0)
                    {
                        break;
                    }
                    node = stack.Peek();
                    Console.WriteLine(node.Data);
                    stack.Pop();
                    node = node.Right;
                }
            }
        }

        public void postOrderItrOneStack(Node root)
        {
            Node current = root;
            Stack<Node> stack = new Stack<Node>();
            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    Node temp = stack.Peek().Right;
                    if (temp == null)
                    {
                        temp = stack.Pop();
                        Console.WriteLine(temp.Data + " ");
                        while (stack.Count >0 && temp == stack.Peek().Right)
                        {
                            temp = stack.Pop();
                            Console.WriteLine(temp.Data + " ");

                        }
                    }
                    else
                    {
                        current = temp;
                    }
                }
            }
        }
    }
}
