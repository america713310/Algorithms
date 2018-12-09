using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.DataStructures
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
    }
    class BinaryTree
    {
        public Node Insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = v;
            }
            else if (v < root.Value)
            {
                root.Left = Insert(root.Left, v);
            }
            else
            {
                root.Right = Insert(root.Right, v);
            }
            return root;
        }
        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            Traverse(root.Left);
            Traverse(root.Right);
        }
    }
}
