using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day5
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {

            LinkedList<int> s1 = new LinkedList<int>();
            s1.AddLast(92);
            s1.AddLast(52);
            s1.AddFirst(92);
            s1.AddLast(43);
            LinkedListNode<int> arr = s1.Find(52);
            s1.AddAfter(arr, 92);

            foreach (int d in s1)
                Console.WriteLine(d);
        }
    }
}
