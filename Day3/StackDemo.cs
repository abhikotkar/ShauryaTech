using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day3
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(52);
            s.Push(425);
            s.Push(242);
            s.Push(2452);
            s.Push(53);
            s.Push(3533);

            foreach (int S in s)
            {
                Console.WriteLine(S);
            }
            Console.WriteLine("__________________________");
            s.Pop();

            foreach (int S in s)
            {
                Console.WriteLine(S);
            }



        }
    }
}
