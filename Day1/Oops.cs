using System;

namespace ShauryaTech.Day1
{
    class Oops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //class object method declaration

    class Employee
    {
        int empid;
        string name;
        int salary;

        public void emp()
        {
            empid = 111;
            name = "Aman";
            salary = 78000;
        }

        public void display()
        {
            Console.WriteLine(empid + " " + name + " " + salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.emp();
            e.display();
        }
    }


    //use of this keyword these are 3 uses of this keyword also use of constructor
    class Car1
    {
        int model_no;
        string name;
        string color;
        int prize;
        string cname;

        public void input(int model_no, string name, string color, int prize)
        {
            this.model_no = model_no;
            this.name = name;
            this.color = color;
            this.prize = prize;
        }

        void show()
        {
            this.input(102, "audi", "white", 3000000);
            Console.WriteLine(model_no);
            Console.WriteLine(name);
            Console.WriteLine(color);
            Console.WriteLine(prize);
        }

        public Car1(string cname)
        {
            this.cname = cname;
            display();
        }

        public void display()
        {
            Console.WriteLine(cname);
        }

        public Car1() : this("Breszza")
        {
            Console.WriteLine("I am the default constructor.");
        }
        static void Main(string[] args)
        {
            Car1 c1 = new Car1();

            c1.show();
        }
    }

    //Polymorphisn 1.Compile time polymorphism
    //Method Overloading.

    class ShowDetails
    {
        void Show()
        {
            Console.WriteLine("Show method");
        }

        void Show(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, float b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, int b, int c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Main(string[] args)
        {
            ShowDetails s = new ShowDetails();
            s.Show();
            s.Show(4, 5);
            s.Show(4, 2.5f);
            s.Show(4, 5, 6);
        }
    }

    //Static class method
    class Static
    {
        static int x = 10;


        public Static()
        {
            x++;
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Static s = new Static();
            Static s1 = new Static();
            Static s2 = new Static();
        }
    }


    //for access non static variable to static variable always create a object of class within the statis method.
    class StaticDemo1
    {
        int x = 10;
        static int y = 20;
        static void get()
        {
            StaticDemo1 d = new StaticDemo1();
            Console.WriteLine(d.x + " " + y);
        }
        void display()
        {
            y = 500;
            Console.WriteLine(x + " " + y);

        }

        static void Main(string[] args)
        {
            StaticDemo1 s = new StaticDemo1();
            get();
            s.display();
        }
    }

    //Encapsulation means property writing and has a relationship means contentment writing.

    //Encapsulation 
    //It is the wrapping of data.
    class Encapsulation1
    {
        private int id;
        private string name;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }

    class EmpInfo
    {
        static void Main(string[] args)
        {
            Encapsulation1 e = new Encapsulation1();
            e.Id = 120;
            e.Name = "Abhi";
            e.Salary = 200000;
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);
        }
    }


    // Single inheritance

    class Animal
    {
        protected string color;
        protected int legs;

    }
    class Dog : Animal
    {
        protected string category;
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.color = "Black";
            d.legs = 4;
            d.category = "Pet";
            Console.WriteLine(d.color + " " + d.legs + " " + d.category);
        }
    }

    //Multilevel inheritance

    class Factory
    {
        protected string name = "MIDC";
        protected int income = 1000000;

    }
    class Owner1 : Factory
    {
        protected string oname = "Amey";

    }

    class Worker1 : Owner1
    {
        protected int salary = 55263;
        static void Main(string[] args)
        {
            Worker1 w = new Worker1();

            Console.WriteLine(w.name + " " + w.income + " " + w.oname + " " + w.salary);
        }
    }
}
