using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListGeneric
{
    public class LinkedListNode<T>
    {
        public T Value { get; internal set; }
        public LinkedListNode<T> Next { get; internal set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
