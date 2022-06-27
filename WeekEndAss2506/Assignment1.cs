using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ShauryaTech.WeekEndAss2506
{
    class Assignment1
    {
    }

    //1. Remove dublicate elements from arraylist

    class ArrayListdemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            foreach (var all in al)
                Console.WriteLine(all);

            Console.WriteLine("The new arraylist is:");
            for (int i = 0; i < al.Count; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (al[k] == al[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {

                    Console.WriteLine(al[i]);
                }

            }
        }
    }

    //2.sort arrat list in reverce order.

    class ArrayListdemo1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sunday");
            al.Add("Monday");
            al.Add("Tusday");
            al.Add("Wendnsday");
            al.Add("Thusday");
            al.Add("Friday");
            al.Add("Saturday");

            Console.WriteLine();
            Console.WriteLine("Reverse Arraylist");
            foreach (var all in al)
                Console.WriteLine(all);

            for (int i = al.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(al[i]);
            }

        }
    }
/*
    //3.

    class Hashtabledemo4
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> ht = new Dictionary<char, int>();
            for (int i = 1; i <= 26; i++)
            {
                ht.Add((char)(64 + i), i);
            }

            foreach(KeyValuePair<char,int> de in ht)
                Console.WriteLine(de.Key+"    "+de.Value);
            string str = Console.ReadLine();
            string[] ch = str.Split(" ");
            for (int i = 0; i < ch.Length; i++)
            {
                string myword = ch[i];
                int sum = 0;
                for (int j = 0; j < myword.Length; j++)
                {
                    sum = sum + KeyValuePair<char, int>.Key[myword[j]];
                }
                
            }
          
        }

    }*/
    

    //5. Update value of given key.
    class Hashtabledemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Amit");
            ht.Add(102, "Om");
            ht.Add(103, "Amey");


            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            ht[103] = "Ajinkya";

            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }

    // 6.value using containtment and pring using foreach loop.

    class Student1
    {
        int id;
        string name;
        int perc;
        public override string ToString()
        {

            return $"Id={id} Name={name} Percentage={perc}";
        }
        public Student1(int id, string name, int perc)
        {
            this.id = id;
            this.name = name;
            this.perc = perc;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Perc { get => perc; set => perc = value; }




        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, perc);
        }

        public override bool Equals(object obj)
        {
            return obj is Student1 student &&
                   id == student.id &&
                   name == student.name &&
                   perc == student.perc;
        }
    }
    class Hashtabledemo2
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(new Student1(101, "Amit", 96), "Shaurya");
            ht.Add(new Student1(102, "Amey", 90), "Shaurya");
            ht.Add(new Student1(103, "Soham", 80), "Shaurya");
            ht.Add(new Student1(104, "Sapna", 89), "Shaurya");
            ht.Add(new Student1(105, "Rakhi", 78), "Shaurya");


            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }

    //7. Update value of given key.
    class Hashtabledemo3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");
            ht.Add(10, "Ten");

            int n = ht.Count;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    ht.Remove(i);

                }

            }
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "   " + de.Value);
            }
        }
    }

    //8. Display frequency in hashtable.

    class ArrayListdemo2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Nashik");
            al.Add("Pune");


            foreach (var all in al)
                Console.WriteLine(all);
            Console.WriteLine("_______________________________________");

            Hashtable ht = new Hashtable();
            for (int i = 0; i < al.Count; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (al[k] == al[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < al.Count; j++)
                    {
                        if (al[i] == al[j])
                            count++;
                    }
                    Console.WriteLine(al[i] + " :" + count);
                    ht.Add(al[i], count);
                }

            }

           

        }
    }
}
