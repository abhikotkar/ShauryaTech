using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShauryaTech.Day8
{
    class Treading1
    {
        static void m1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);//default thread
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hii");
            Console.WriteLine("Good Morning");
            m1();
            Console.WriteLine("Main Ends");
        }
    }

    class Treading2
    {
        static void m1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + Thread.CurrentThread.Name);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hii");
            Console.WriteLine("Good Morning");
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(m1);
            t1.Name = "Ram";
            t2.Name = "raj";
            t1.Start();
            t2.Start();
            Console.WriteLine("Main Ends");
        }
    }
}
