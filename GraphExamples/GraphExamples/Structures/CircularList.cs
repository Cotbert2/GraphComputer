using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExamples.Structures
{

    public class CircularList<T>
    {
        private CircularNode<T> head;
        private int count = 0;

        public void Add(T data)
        {
            CircularNode<T> newNode = new CircularNode<T>(data);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                CircularNode<T> temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Next = head;
            }

            count++;
        }

        public CircularNode<T> GetHead() => head;

        public int Count => count;
    }
}
