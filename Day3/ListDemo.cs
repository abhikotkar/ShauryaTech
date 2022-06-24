using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day3
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();
            s.Add("Shaurya");
            s.Add("Technosoft");
            s.Add("Private");
            s.Add("Limited");
            

            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine("_________________________________________");
            s.Insert(2, "Solutions");

            foreach (var ob in s)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("_________________________________________");
            s[3] = "Pvt";

            foreach (var ob in s)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("_________________________________________");
            s.Remove("Solutions");

            foreach (var ob in s)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
