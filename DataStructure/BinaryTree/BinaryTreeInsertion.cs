using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class Node
    {
        public Node()
        {
        }
        public Node(int item)
        {
            Data = item;
            Left = Right = null;
        }
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class BinaryTreeInsertion
    {
        Node BinaryTree;
        public Node Insert(int i)
        {
            Node Root = new Node();
            Root.Data = i;

            if (BinaryTree == null)
            {
                BinaryTree = Root;
            }

            else
            {
                Node currentNode = BinaryTree;
                Node Node2Add;
                while (true)
                {
                    Node2Add = currentNode;
                    if (i < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            Node2Add.Left = Root;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            Node2Add.Right = Root;
                            break;
                        }
                    }
                }


            }
            return BinaryTree;





        }
    }

    public class BinaryTreeLevelInsertion
    {
        public void levelorderinsertion()
        {
            Node binarytree;
            int count = 0;
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Node nodes = new Node();
            nodes.Data = list[count];
            list.RemoveAt(count);

            Queue<Node> Queenodes = new Queue<Node>();
            binarytree = nodes;
            Node test = binarytree;
            while (list.Count > 0)
            {
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


        //Implementation
        //BinaryTreeLevelInsertion binaryTreeInsertion = new BinaryTreeLevelInsertion();
        //binaryTreeInsertion.levelorderinsertion();  

    }

}
