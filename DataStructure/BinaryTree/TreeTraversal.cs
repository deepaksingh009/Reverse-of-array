using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class TreeTraversal
    {
        public void Preorder(tNode node)
        {
            if (node == null)
            {
                return;
            }
            //preorder
            //DLR

            Preorder(node.left);
            Console.WriteLine(node.data);
            Preorder(node.right);
        }
        public void inOrder(tNode node)
        {
            if (node == null)
            {
                return;
            }
            //Inorder
            //LRD
            inOrder(node.left);
            Console.WriteLine(node.data);
            inOrder(node.right);
        }
        public void PostOrder(tNode node)
        {
            if (node == null)
            {
                return;
            }
            //Postorder
            //RDL
            PostOrder(node.left);
            Console.WriteLine(node.data);
            PostOrder(node.right);
        }
    }

    //implenation

    //MorriseInordertreetraversal tree = new MorriseInordertreetraversal();
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
}
