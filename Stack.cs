using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    internal class Stack<T>

    {
        LinkedNode<T>? Head;
        LinkedNode<T> newNode;
        int count = 0;
        public Stack()
        {
            Head = null;
        }

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }


        public void Push(T value)
        {

            newNode = new LinkedNode<T>(value);

            if (Head == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = Head;
            }
            Head = newNode;
            count++;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow. Already deleted last item.");
            }
            else
            {
                Console.WriteLine($"{Head}");
                count--;
            }
            Head = Head.next;
        }

        public int Size()
        {
            return count;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow.");
            }
            Console.WriteLine($"{Head.value}");
        }
    } 
}