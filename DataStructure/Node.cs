using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class Node
    {
        public int value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node(int value)
        {
            this.value = value;

        }


    }
}
