﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class Node
    {
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

    public class Unbalancesbst
    {
        Node Bst;
        static int Left = 0;
        static int right = 0;

        public void Insert(int i)
        {

            Node singlenode = new Node();
            singlenode.Data = i;



            if (Bst == null)
            {
                Bst = singlenode;
            }
            else
            {
                Node Temp = Bst;

                if (Temp.Left == null)
                {

                }
                else
                {

                }




            }
        }

    }

    public class BinaryTreeNode
    {
        private int id;
        public void setID(int _id) { id = _id; }
        public int getID() { return id; }
        public BinaryTreeNode left; public BinaryTreeNode right;
        public BinaryTreeNode() { left = right = null; }
        public BinaryTreeNode(int _id) { id = _id; left = right = null; }
    }
    public class BinaryTree
    {
        private BinaryTreeNode root;
        public BinaryTree() { root = null; }
        int val = 2;
        int level = 0;
        int j = 0;

        public void insert(int c)
        {
            addNode(c, ref root);
        }
        private void addNode(int c, ref BinaryTreeNode rptr)
        {
            if (rptr == null)

                //when current node is null
                rptr = new BinaryTreeNode(c);
            else if (rptr.left == null)
            //when current node's left chid is null :-left Subtree
            {
                addNode(c, ref rptr.left);
                val--;
            }
            else if (rptr.right == null)
            //when current node's Right chid is null :-left Subtree
            {
                addNode(c, ref rptr.right);
                val--;
                if (val == 0)
                {
                    level = level + 2;
                    val = level * 2;
                    j++;
                }
            }

            else if (val > (val / 2) + 1)

            {
                bool u = Test(rptr.left.left);
                if (u == false)
                {
                    addNode(c, ref rptr.left);
                }
                else
                {
                    addNode(c, ref rptr.right);
                }


            }
            else if (val <= (val / 2) + 1)
          
            {
                addNode(c, ref rptr.right);

            }


        }

        public void inOrderTraversal()
        {
            inOrderTraversalHelper(root);
        }
        private void inOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                inOrderTraversalHelper(r.left);
                Console.Write("{0}   ", r.getID());
                inOrderTraversalHelper(r.right);
            }
        }
        public void preOrderTraversal()
        {
            preOrderTraversalHelper(root);
        }
        private void preOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                Console.Write("{0}   ", r.getID());
                preOrderTraversalHelper(r.left);
                preOrderTraversalHelper(r.right);
            }
        }
        public void postOrderTraversal()
        {
            postOrderTraversalHelper(root);
        }
        private void postOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                postOrderTraversalHelper(r.left);
                postOrderTraversalHelper(r.right);
                Console.Write("{0}   ", r.getID());
            }
        }

        public bool Test(BinaryTreeNode binaryTreeNode)
        {
            bool returnresuly=false;
            if (binaryTreeNode != null)
            {

                if (binaryTreeNode.left == null || binaryTreeNode.right == null)
                {
                    returnresuly = false;
                }
                else if ((binaryTreeNode.left != null && binaryTreeNode.right != null))
                {
                    returnresuly = true;

                }
                else
                {
                    returnresuly = true;
                }

            }
            return returnresuly;
        }     
    }
}
