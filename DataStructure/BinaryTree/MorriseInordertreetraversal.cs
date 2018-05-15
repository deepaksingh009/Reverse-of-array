using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class MorriseInordertreetraversal
    {
        public tNode root;

        /* Function to traverse binary tree without recursion and 
           without stack */
        public void MorrisTraversal(tNode root)
        {
            tNode current, pre;

            if (root == null)
                return;

            current = root;
            while (current != null)
            {
                if (current.left == null)
                {
                    Console.WriteLine(current.data + " ");
                    current = current.right;
                }
                else
                {
                    /* Find the inorder predecessor of current */
                    pre = current.left;
                    while (pre.right != null && pre.right != current)
                        pre = pre.right;

                    /* Make current as right child of its inorder predecessor */
                    if (pre.right == null)
                    {
                        pre.right = current;
                        current = current.left;
                    }

                    /* Revert the changes made in if part to restore the 
                       original tree i.e.,fix the right child of predecssor*/
                    else
                    {
                        pre.right = null;
                        Console.WriteLine(current.data + " ");
                        current = current.right;
                    }   /* End of if condition pre->right == NULL */

                } /* End of if condition current->left == NULL*/

            } /* End of while */

        }
    }
    public class tNode
    {
        public int data;
        public tNode left, right;

        public tNode(int item)
        {
            data = item;
            left = right = null;
        }
    }
}

/// summary
/// IMplementation
/// sumaary

//b tree = new b();
//tree.root = new tNode(1);
//tree.root.left = new tNode(2);
//tree.root.right = new tNode(3);
//tree.root.left.left = new tNode(4);

//tree.root.left.right = new tNode(5);

//tree.root.right.left = new tNode(6);

//tree.root.right.right = new tNode(7);


//tree.root.left.left.left = new tNode(8);
//tree.root.left.left.right = new tNode(9);

//tree.root.left.right.left = new tNode(10);
//tree.root.left.right.right = new tNode(11);

//tree.root.right.left.left = new tNode(12);
//tree.root.right.left.right = new tNode(13);

//tree.root.right.right.left = new tNode(14);
//tree.root.right.right.right = new tNode(15);




//tree.MorrisTraversal(tree.root);


