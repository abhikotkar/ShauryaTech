using System;
using System.Collections.Generic;

namespace ShauryaTech.Day4
{
    class DictionaryDemo1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(101, "Amit");
            di.Add(102, "Om");
            di.Add(103, "Amey");

            Console.WriteLine(di[101]);

            di[103] = "Ajinkya";

            di.Remove(102);

            foreach(KeyValuePair<int,string> kv in di)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }
        }
    }


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
        class DictionaryDemo2
    {
        static void Main(string[] args)
        {
            Dictionary<Student, string> di = new Dictionary<Student, string>();
            di.Add(new Student(101,"Amit",96), "Shaurya");
            di.Add(new Student(102, "Amey", 92), "Shaurya");

            
            foreach (KeyValuePair<Student, string> kv in di)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
