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

        //public Node ReturnRoot()
        //{ return Root; }

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




    }
}
