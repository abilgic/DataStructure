using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        private Node Head;
        private Node Last;
        public  void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Value} |");
                current = current.Next;
                //Debug.WriteLine($"{current.Value} |");                
            }

        }

        public void Add(int value)
        {           
            if (Head == null)
            {                
                Head = new Node(value);
                return;
            }
            var current = Head;
            while (current.Next!= null)
            {
                current = current.Next;
            }
           
            var newnode = new Node(value);
            
            current.Next = newnode;

        }
        public void Delete(int value)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Value == value)
            {
                Head = Head.Next;
                return;
            }
            var current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }

        }
    }
}
