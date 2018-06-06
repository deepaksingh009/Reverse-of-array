using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DataStructure.BinaryTree
{
    public class TreeTraversal
    {
        public void Preorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            //preorder
            //DLR
            Console.WriteLine(node.Data);
            Preorder(node.Left);

            Preorder(node.Right);
        }


        public void inOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            //Inorder
            //LDR
            inOrder(node.Left);
            Console.WriteLine(node.Data);
            inOrder(node.Right);

        }
        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            //Postorder
            //LRD
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Data);
        }
    }

    public class LevelorderTraversal
    {
        public void Levelodertraversal(Node node)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(node);
            while (nodeQueue.Count > 0)
            {
                Node nodetoprint = new Node();

                nodetoprint = nodeQueue.Dequeue();
                Console.WriteLine(nodetoprint.Data);


                if (nodetoprint.Left != null)
                {
                    nodeQueue.Enqueue(nodetoprint.Left);

                }
                if (nodetoprint.Right != null)
                {
                    nodeQueue.Enqueue(nodetoprint.Right);

                }
            }

        }
    }

    public class Heightoftree
    {
        int left = 0;
        int right = 0;
        int height = 0;
        Stack<Node> nodestack = new Stack<Node>();
        public int TreeHeightRecursives(Node node)
        {
            if (node == null)
                return 0;
            if (node.Left != null)
            {
                left++;
                TreeHeightRecursives(node.Left);
            }

            if (node.Right != null)
            {
                right++;
                TreeHeightRecursives(node.Right);
            }
            if (left > right)
            { return left + 1; }
            else
            { return right + 1; }
        }

        public int TreeHeightIterative(Node node)
        {
            if (node == null)
                return 0;

            nodestack.Push(node);
            while (nodestack.Count > 0)
            {
                Node currentnode = new Node();
                currentnode = nodestack.Pop();
                if (currentnode.Left != null)
                {
                    nodestack.Push(currentnode.Left);
                }
                if (currentnode.Right != null)
                {
                    nodestack.Push(currentnode.Right);

                }
                if (currentnode.Right == null && currentnode.Left == null)
                { }
                else
                { height++; }


            }
            return height;
        }
    }

    public class spiralordertraversal
    {
        public void spiralOrder(Node node)
        {
            Stack<Node> Statcknodes = new Stack<Node>();
            Queue<Node> queuenodes = new Queue<Node>();
            int number = 0;
            //queuenodes.Enqueue(node);
            Statcknodes.Push(node);

            while (true)
            {
                Node CurrrentNode = new Node();
                if (number % 2 != 0)
                {
                    CurrrentNode = queuenodes.Dequeue();

                    Console.WriteLine(CurrrentNode.Data);
                    if (CurrrentNode.Left != null)
                        Statcknodes.Push(CurrrentNode.Left);
                    if (CurrrentNode.Right != null)
                        Statcknodes.Push(CurrrentNode.Right);

                    if (queuenodes.Count <= 0)
                    {
                        if (Statcknodes.Count <= 0)
                        {
                            break;
                        }
                        else
                        {
                            number++;
                        }
                    }
                }

                else
                {
                    CurrrentNode = Statcknodes.Pop();
                    Console.WriteLine(CurrrentNode.Data);
                    if (CurrrentNode.Left != null)
                        queuenodes.Enqueue(CurrrentNode.Left);
                    if (CurrrentNode.Right != null)
                        queuenodes.Enqueue(CurrrentNode.Right);

                    if (Statcknodes.Count <= 0)
                    {
                        if (queuenodes.Count <= 0)
                        { break; }
                        else
                            number++;
                    }
                }
            }
        }
    }
    public class QItem
    {
        public Node node;
        public int hd;
        public QItem(Node n, int h)
        {
            node = n;
            hd = h;
        }
    }
    public class Printtopview
    {
        Node nodes;
        public Printtopview(Node node)
        {
            nodes = node;
        }
        public void TopView()
        {
            HashSet<int> vs = new HashSet<int>();
            Queue<QItem> queue = new Queue<QItem>();
            queue.Enqueue(new QItem(nodes, 0));

            while (queue.Count > 0)
            {
                QItem qItem = queue.Dequeue();

                Node currentnode = qItem.node;
                int hd = qItem.hd;

                if (!vs.Contains(hd))
                {
                    vs.Add(hd);
                    Console.WriteLine(currentnode.Data + " ");
                }

                if (currentnode.Left != null) 
                queue.Enqueue(new QItem(currentnode.Left, hd - 1));

                if (currentnode.Right != null) 
                queue.Enqueue(new QItem(currentnode.Right, hd + 1));

            }
            //HashSet<>
        }
    }



    // A class to represent a queue item. The queue is used to do Level
    // order traversal. Every Queue item contains node and horizontal
    // distance of node from root


    // Class for a Binary Tree
    class Tree
    {
        Node root;

        // Constructors
        public Tree() { root = null; }
        public Tree(Node n) { root = n; }

        // This method prints nodes in top view of binary tree
        public void printTopView()
        {
            // base case
            if (root == null) { return; }

            // Creates an empty hashset
            HashSet<int> set = new HashSet<int>();

            // Create a queue and add root to it
            Queue<QItem> Q = new Queue<QItem>();
            Q.Enqueue(new QItem(root, 0)); // Horizontal distance of root is 0

            // Standard BFS or level order traversal loop
            while (Q.Count > 0)
            {
                // Remove the front item and get its details
                QItem qi = Q.Dequeue();
                int hd = qi.hd;
                Node n = qi.node;

                // If this is the first node at its horizontal distance,
                // then this node is in top view
                if (!set.Contains(hd))
                {
                    set.Add(hd);
                    Console.WriteLine(n.Data + " ");
                }

                // Enqueue left and right children of current node
                if (n.Left != null)
                    Q.Enqueue(new QItem(n.Left, hd - 1));
                if (n.Right != null)
                    Q.Enqueue(new QItem(n.Right, hd + 1));
            }
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



    #region    LevelorderTraversalImplementation

    //Node root = null;
    //root = new Node(1);
    //root.Left = new Node(2);
    //root.Right = new Node(3);
    //root.Left.Left = new Node(4);
    //root.Left.Right = new Node(5);
    //root.Right.Left = new Node(6);
    //root.Right.Right = new Node(7);

    //LevelorderTraversal levelorderTraversal = new LevelorderTraversal();
    //levelorderTraversal.Levelodertraversal(root);
    #endregion

    #region  TreeHeightRecursives && TreeHeightIterative Implementation
    //Node root = null;
    //root = new Node(1);
    //root.Left = new Node(2);
    //root.Right = new Node(3);
    //root.Left.Left = new Node(4);
    //root.Left.Right = new Node(5);
    //root.Right.Left = new Node(6);
    //root.Right.Right = new Node(7);
    //root.Right.Left.Right = new Node(8);
    //root.Right.Left.Right.Left = new Node(9);
    //root.Right.Left.Right.Left.Right = new Node(10);

    //Heightoftree heightoftree = new Heightoftree();
    //int f = heightoftree.TreeHeightRecursives(root);
    //int j = heightoftree.TreeHeightIterative(root);
    #endregion
}
