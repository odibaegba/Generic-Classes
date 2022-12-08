using System;

namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<string> names = new LinkedList<string>();
            names.AddToTail("steve");
            names.AddToTail("fred");
            names.AddToTail("mark");

            Console.WriteLine(names.Count);
            Console.WriteLine(names.Check("steve"));
            Console.WriteLine(names.Index("mark"));
           Console.WriteLine(names.Remove("fred"));

            Stack<string> places = new Stack<string>();
            Console.WriteLine(places.IsEmpty());

            places.Push("kaduna");
            places.Push("jos");
            places.Push("lagos");

            Console.WriteLine(places.IsEmpty());
            Console.WriteLine();

            Console.WriteLine(places.Size());
            Console.WriteLine();

            places.Peek();
            Console.WriteLine();
            places.Pop();

            MyQueue<string> countries = new MyQueue<string>();

            Console.WriteLine(countries.IsEmpty());

            countries.Enqueue("Nigeria"); 
            countries.Enqueue("Belarus");
            countries.Enqueue("Egypt");

            Console.WriteLine(countries.IsEmpty());
            countries.Dequeue();

            
        }
    }
}
