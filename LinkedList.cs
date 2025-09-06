using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace ex2
{
    public class LinkedList
    {
        public Node Head;
        public Node Last;
        public LinkedList()
        {
            Head = null;
            Last = null;
        }
        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
        public int Pop()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            Node current = Head;
            for (; current.Next != null && current.Next.Next!=null; current = current.Next) ;
            int value = current.Next.Value;
            current.Next = null;
            Last = current;
            return value;
        }
        public void Append(int value)
        {
            Last.Next = new Node(value);
            Last = Last.Next;
        }
        public int Unqueue()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (Head == Last)
            {
                Node temp = Head;
                Head = null;
                Last = null;
                return temp.Value;
            }
            else
            {
                Node temp = Head;
                Head = Head.Next;
                return temp.Value;
            }
        }
        public IEnumerable<int> ToList()
        {
            IEnumerable<int> result = new List<int>();
            for (Node current = Head; current != null; current = current.Next)
            {
                result = result.Append(current.Value);
            }
            return result;
        }

        public bool IsCircular()
        {
            if (Last!=null && Head == Last.Next)
                return true;
            return false;
        }
        
    }

}
