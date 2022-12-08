using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task22
{
    public class MyQueue<T>
    {
        LinkedNode<T>? front;
        LinkedNode<T>? back;
        LinkedNode<T>? newNode;
        int count = 0;

        public MyQueue()
        {
            front = back = null;
        }

        public bool IsEmpty()
        {
            return front == null && back == null;
        }

        public void Enqueue(T value)
        {
            newNode = new LinkedNode<T>(value);
            if (back == null)
            {
                front = back = newNode;
            }
            else
            {
                back.next = newNode;
                back = newNode;
            }
            count++;
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Oops! Queue is empty!");
            }
            LinkedNode<T>? current = front;
            front = front.next;
            count--;

            if (front == null)
            {
                back = null;
            }

            Console.WriteLine("{0}", current.value);
        }
        public int Count()
        {
            return count;
        }
    }
}









