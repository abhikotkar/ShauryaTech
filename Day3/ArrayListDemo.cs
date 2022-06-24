using System;
using System.Collections;

namespace ShauryaTech.Day3
{
    class ArrayListDemo
    {

        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Hello World!");
            }

        }
    }

    class Emp
    {
        public Emp(int empid, string empname)
        {
            Console.WriteLine("Emp ID=" + empid + " Emp Name=" + empname);
        }
        public Emp()
        {

        }
    }
    class ArrayCollection
    {

       
        static void Main(string[] args)
        {
            
            ArrayList al = new ArrayList();
            al.Add(90);
            al.Add("abhi");
            al.Add(353);
            al.Add(25.13f);
            al.Add("Shaurya");
            al.Add(new Emp(56695,"Amit"));
            al.Add(25.154f);

            for (int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.WriteLine("_________________________________________");
            al.Insert(4, 20);

            foreach(var ob in al)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("_________________________________________");
            al[3]="Tech";

            foreach (var ob in al)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("_________________________________________");
            al.Remove(20);

            foreach (var ob in al)
            {
                Console.WriteLine(ob);
            }

        }
    }
}
