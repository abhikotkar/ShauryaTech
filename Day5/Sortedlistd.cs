using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day5
{
    class Sortedlistd
    {
        static void Main(string[] args)
        {

            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Ram",95);
            ss.Add("Ajay", 87);
            ss.Add("Ajit", 65);
            ss.Add("Sujit", 55);

            foreach(KeyValuePair<string,int> sss in ss)
            {
                Console.WriteLine(sss.Key+"==>"+sss.Value);
            }
        }
    }

    class Student1:IComparable<Student1>
    {
        int id;
        string name;
        int perc;

        public override string ToString()
        {
            
            return $"Id={id} Name={name} Percentage={perc}";
        }
        public int CompareTo(Student1 s2)
        {
            //is for decending sort
           /* if (this.perc == s2.perc)
                return s2.name.CompareTo(this.name);
            else
                return s2.perc.CompareTo(this.perc);*/
            if (this.perc==s2.perc)
                return this.name.CompareTo(s2.name);
            else
                return this.perc.CompareTo(s2.perc);
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

    }

    class Sortedlistdemo
    {
        static void Main(string[] args)
        {

            SortedList<Student1, string> ss = new SortedList<Student1, string>();
            ss.Add(new Student1(101, "Ram", 95), ".NET");
            ss.Add(new Student1(101, "Ajay", 87), "JAVA");
            ss.Add(new Student1(101, "Ajit", 65), "C");
            ss.Add(new Student1(101, "Sujit", 65), "CPP");

            foreach (KeyValuePair<Student1, string> sss in ss)                      
            {
                Console.WriteLine(sss.Key + "==>" + sss.Value);
            }
        }
    }


    class Mycompare:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1,StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }                   

    class Sortedlistdemo1
    {
        static void Main(string[] args)
        {

            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>(new Mycompare());
            ss.Add(new StringBuilder("Ram"),92);
            ss.Add(new StringBuilder("Amey"), 52);
            ss.Add(new StringBuilder("harish"), 96);
            ss.Add(new StringBuilder("dipak"), 82);

            foreach (KeyValuePair<StringBuilder, int> sss in ss)
            {
                Console.WriteLine(sss.Key + "==>" + sss.Value);
            }
        }
    }
}
