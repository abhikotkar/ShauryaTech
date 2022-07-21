using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.AdonetDay1
{
    
        public class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
        }
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Student> Students = new List<Student>();
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Course> coures = new List<Course>() {
                new Course{Id=101,Name="C#",Students={
                                         new Student{RollNo=1,Name="Rohan"},
                                         new Student{RollNo=2,Name="Suraj"},
                                         new Student{RollNo=3,Name="Amit"},
                                            }
                },
                  new Course{Id=102,Name="MVC",Students={
                                         new Student{RollNo=4,Name="Ajinkya"},
                                         new Student{RollNo=5,Name="Amol"},
                                         new Student{RollNo=6,Name="Neha"},
                                            }
                },
                      new Course{Id=103,Name="SQL",Students={
                                         new Student{RollNo=7,Name="Smita"},
                                         new Student{RollNo=8,Name="Gaurav"},
                                         new Student{RollNo=9,Name="Manohar"},
                                            }
                },
            };

                foreach (Course c in coures)
                {
                    Console.WriteLine($"{c.Id}  {c.Name}");
                    foreach (Student s in c.Students)
                    {
                        Console.WriteLine($"\t {s.Name}");
                    }
                }
            }
        }

    }

