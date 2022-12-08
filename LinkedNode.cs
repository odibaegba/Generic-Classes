using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    internal class LinkedNode<T>
    {
        public T value { get; set; }
        public LinkedNode<T> next { get; set; }

        public LinkedNode(T Value)
        {
            value = Value;
            next = null;
        }
    }
}
