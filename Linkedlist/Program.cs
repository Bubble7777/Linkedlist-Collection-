using System;

namespace Linkedlist
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        private static void PrintList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        static void Main(string[] args)
        {
            Node first = new Node();
            first.Value = 3;
            Node midle = new Node();
            midle.Value = 7;
            Node last = new Node();
            last.Value = 9;
            first.Next = midle;
            midle.Next = last;

            PrintList(first);
        }
    }
}
