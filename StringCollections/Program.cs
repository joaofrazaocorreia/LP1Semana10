using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            Stack<String> stack = new Stack<String>();
            Queue<String> queue = new Queue<String>();
            HashSet<String> hashSet = new HashSet<String>();

            List<Object> collections = new List<Object>();

            collections.Add(list);
            collections.Add(stack);
            collections.Add(queue);
            collections.Add(hashSet);

            string string1 = "Hello";
            string string2 = "World";
            string string3 = "and";
            string string4 = "Hello";
            string string5 = "Neighbor";

            foreach (IEnumerable<String> c in collections)
            {
                if (c.GetType() == list.GetType())
                {
                    (c as List<String>).Add(string1);
                    (c as List<String>).Add(string2);
                    (c as List<String>).Add(string3);
                    (c as List<String>).Add(string4);
                    (c as List<String>).Add(string5);
                }
                else if (c.GetType() == stack.GetType())
                {
                    (c as Stack<String>).Push(string1);
                    (c as Stack<String>).Push(string2);
                    (c as Stack<String>).Push(string3);
                    (c as Stack<String>).Push(string4);
                    (c as Stack<String>).Push(string5);
                }
                else if (c.GetType() == queue.GetType())
                {
                    (c as Queue<String>).Enqueue(string1);
                    (c as Queue<String>).Enqueue(string2);
                    (c as Queue<String>).Enqueue(string3);
                    (c as Queue<String>).Enqueue(string4);
                    (c as Queue<String>).Enqueue(string5);
                }
                else
                {
                    (c as HashSet<String>).Add(string1);
                    (c as HashSet<String>).Add(string2);
                    (c as HashSet<String>).Add(string3);
                    (c as HashSet<String>).Add(string4);
                    (c as HashSet<String>).Add(string5);
                }
                foreach (String s in c)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
        }
    }
}
