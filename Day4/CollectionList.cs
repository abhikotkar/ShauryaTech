using System;
using System.Collections.Generic;

namespace ShauryaTech.Day4
{
    class Student
    {
        int id;
        string name;
        int perc;

        public Student(int id, string name, int perc)
        {
            this.id = id;
            this.name = name;
            this.perc = perc;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Perc { get => perc; set => perc = value; }

        public override string ToString()
        {
            return $"Id:{id} Sname:{name} Percentage:{perc}";
        }
       
    }

    class ListDemo
    {
        static void Main(string[] args)
        {
            List<Student> s = new List<Student>();
            s.Add(new Student(111, "Amit", 96));
            s.Add(new Student(112, "Shiv", 78));
            s.Add(new Student(113, "Sahil", 81));
            s.Add(new Student(114, "Amey", 59));

            foreach(Student ol in s)
            {
                if(ol.Perc>80)
                {
                    Console.WriteLine(ol);
                }
            }
        }                                                                                                                                             
    }


}
