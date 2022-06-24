using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day3
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(52);
            q.Enqueue(25525);
            q.Enqueue(535332);
            q.Enqueue(5335352);
            q.Enqueue(532);
            q.Enqueue(5362);

            foreach (int Q in q)
            {
                Console.WriteLine(Q);
            }
            Console.WriteLine("__________________________");
            q.Dequeue();

            foreach (int Q in q)
            {
                Console.WriteLine(Q);
            }



        }
    }
}

