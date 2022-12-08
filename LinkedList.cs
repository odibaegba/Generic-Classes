using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace Task22
{
    internal class LinkedList<T>
    {
        public LinkedNode<T> Head { get; set; }
        public int Count { get; set; }

        public int AddToTail(T Value)
        {
            if (Head == null)
            {
                Head = new LinkedNode<T>(Value);
                Count++;
            }
            else
            {
                LinkedNode<T> Current = Head;
                while (Current.next != null)
                {
                    Current = Current.next;

                }
                Current.next = new LinkedNode<T>(Value);
                Count++;

            }
            return Count;

        }

        public bool Remove(T value)
        {
            var current = Head;
            LinkedNode<T> previous = null;

            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    if (previous == null)
                    {
                        Head = Head.next;
                        Count--;
                        return true;
                    }
                    previous.next = current.next;
                    Count--;
                    return true;
                }
                previous = current;
                current = current.next;
            }

            return false;



        }

        public bool Check(T value)
        {
            var Current = Head;
            while (Current != null)
            {
                if (Current.value.Equals(value))
                { 
                    return true; 
                
                }
                Current = Current.next;
            }
            return false;
        }

        public int Index(T value)
        {
            int count = 0;
            while (Head != null)
            {
                if (Head.value.Equals(value))
                {
                    return count;
                }
                Head = Head.next;
                count++;
            }

            return -1;
        }
    }
}