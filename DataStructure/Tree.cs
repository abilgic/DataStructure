using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class Tree
    {
        public Node root;

        public Node ReturnRoot()
        { return root; }

        public void Insert(int value)
        {
            var node = new Node(value);
            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = new Node(value);
                        break;
                    }
                    current = current.LeftChild;

                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = new Node(value);
                        break;
                    }
                    current = current.RightChild;

                }

            }

        }

        public void PreOrderTraverse(Node root)
        {
            var current = root;

            if (current == null)
            {
                return;
            }
            Console.Write(current.value + " ");
            PreOrderTraverse(current.LeftChild);
            PreOrderTraverse(current.RightChild);

        }

        public void InOrderTraverse(Node root)
        {
            var current = root;

            if (current == null)
            {
                return;
            }

            InOrderTraverse(current.LeftChild);
            Console.Write(current.value + " ");
            InOrderTraverse(current.RightChild);

        }

        public void PostOrderTraverse(Node root)
        {
            var current = root;

            if (current == null)
            {
                return;
            }

            PostOrderTraverse(current.LeftChild);
            PostOrderTraverse(current.RightChild);
            Console.Write(current.value + " ");

        }
    }
}
