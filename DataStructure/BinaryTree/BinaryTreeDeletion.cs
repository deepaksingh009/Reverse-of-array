using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.DataStructure.BinaryTree;

namespace ConsoleApp2.DataStructure
{
	public class BinaryTreeDeletion
	{
		public void Delete(Node Nodes, int itemToDelete)
		{
			Node n = Nodes;

			if (n.Data < itemToDelete)
			{
				n.Left = null;
			}
			else
			{
				n.Right = null;
			}


		}
	}
}
