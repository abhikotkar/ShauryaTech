using System;

namespace ShauryaTech.Day1
{
    class Ass1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

   /* 1.	Create class Teacher with following

    Tid,Tname,MobileNo
    Parameterized constructor
    abstract void salary()
•	Create class Hourlybased which is derived class from teacher with fields
     rate_per_hr,

    int hrs;
    Parameterized constructor

    void salary()
•	Create class SalaryBased which is derived class from teacher
    with fields
     int salary;
    Parameterized constructor

    void salary()
Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective salary method and also show runtime polymorphism
*/

    abstract class Teacher
    {
        public int tno;
        public string tname;
        public long mobno;

        public Teacher(int tno, string tname, long mobno)
        {
            this.tno = tno;
            this.tname = tname;
            this.mobno = mobno;
        }

        public virtual void display()
        {

            Console.WriteLine("Tno= " + tno + " Tname= " + tname + " MobNo= " + mobno);
        }
       
        public abstract void salary();//abstract method

    }

    class Hourlybased : Teacher
    {
        int rate_per_hr;
        int hrs;

        public Hourlybased(int rate_per_hr, int hrs,int tno, string tname, long mobno) : base(tno, tname,mobno)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;
        
        }

        public override void display()
        {

            Console.WriteLine("Rate per Hr= " + rate_per_hr + " hrs= " + hrs);
        }

       
        public override void salary()
        {
           
            Console.WriteLine("Salary= "+(rate_per_hr*hrs));
        }
    }

    class SalaryBased:Teacher
    {
        
        int sal;
        public SalaryBased(int sal, int tno, string tname, long mobno):base(tno, tname, mobno)
        {
            this.sal = sal;
        }

        public override void display()
        {

            Console.WriteLine("Salary= " + sal);
        }

        
        public override void salary()
        {
          
           
            Console.WriteLine("Salary= " + sal);
        }
    }

    class MainMenu
    {
        static void Main(string[] args)
        {
            Teacher h = new Hourlybased(250,2,123,"dsfdsfg",5685421525);

            h.display();
            h.salary();

            Teacher s = new SalaryBased(25000,5425,"sdgsr",68556852);
           
           
            s.display();
            s.salary();
        }
    }

    /*2.	A Pen contains variables Refill r, int capLength and String brand.
   Refill has variables inkColor, length and Nib(tip).
	 Nib has variables materialType and width.
    Create a Java class structure for above.
Write a main method which sets values in all the variables
using setter methods and prints all the variables using getter methods.*/


    class Nib
    {
        private string meterial_typr;
        private int width;

        public string Meterial_typr { get => meterial_typr; set => meterial_typr = value; }
        public int Width { get => width; set => width = value; }
    }
        class Refill
    {
        private string inkcolor;
        private int length;
        private Nib nib;

       
        public string Inkcolor { get => inkcolor; set => inkcolor = value; }
        public int Length { get => length; set => length = value; }
        public Nib Nib { get => nib; set => nib = value; }
    }

    class Pen
    {
        private int caplength;
        private string brand;
        private Refill reff;

        public int Caplength { get => caplength; set => caplength = value; }
        public string Brand { get => brand; set => brand = value; }
        public Refill Reff { get => reff; set => reff = value; }
       

        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Caplength = 2;
            p.Brand = "Cello";
            Refill r = new Refill();
            r.Inkcolor = "Black";
            r.Length = 5;
            Nib n = new Nib();
            n.Meterial_typr = "Metal";
            n.Width = 1;
            Console.WriteLine(p.Caplength + " " + p.Brand + " " +r.Inkcolor + " " + r.Length + " " +n.Meterial_typr+" "+n.Width);
        }
    }

    /*3.	Write a java program to create 2 person objects .Take input or hardcode  for all  two person from console. Person class is as follows 
    Person (int id, String name, Vehicle v )
    Vehicle (int vid, String vname) 
    */
    class Vehicle
    {
        int vid;
        string vname;

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }

        public void display1()
        {

            Console.WriteLine("Vehice id:" + Vid);
            Console.WriteLine("Vehicle name:" + Vname);

        }
    }
    class Person
    {
        int id;
        string name;
        Vehicle v;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Vehicle V { get => v; set => v = value; }

        public void display1()
        {
           
            Console.WriteLine("Person no:" + Id);
            Console.WriteLine("Person name:" + Name);
            
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Vehicle v = new Vehicle();
            
                p.Id=123;
                p.Name = "Amit";
                p.display1();
                v.Vid = 5661;
                v.Vname = "Brezza";
                v.display1();
                Console.WriteLine();

            Person p1 = new Person();
            Vehicle v1 = new Vehicle();

            p1.Id = 153;
            p1.Name = "Amey";
            p1.display1();
            v1.Vid = 8961;
            v1.Vname = "Creata";
            v1.display1();
            Console.WriteLine();

        }
    }

    //4.Create interface Cake with a method declared as bake. Create 2 classes 
    //Strawberry, BlackForest both implementing Cake interface.
    public interface Cake
    {
        void bake();
    }

    class Strawberry : Cake
    {
        public void bake()
        {
           
            Console.WriteLine("Strawberry cake bake in 20 minutes");
            
        }
       
    }
    class Blackforest : Cake
    {
        public void bake()
        {
           
            Console.WriteLine("Blackforest cake bake in 30 minutes");

        }


    }

    class Interfacedemos
    {
        static void Main(string[] args)
        {
            Cake c = new Strawberry();
            c.bake();
            Cake b = new Blackforest();
            b.bake();
        }
    }

    /*5.	 Create interface IceCream with method eat and Juice with method drink, 
             Create class Mastani which implements both interfaces. 
    */

    public interface IceCream
    {

        void Eat();

    }

    public interface Juice
    {

        void Drink();


    }

    class Mastani:IceCream,Juice
    {
        public void Eat()
        {
            Console.WriteLine("Eat IceCream");
        }
        public void Drink()
        {
            Console.WriteLine("Drink Juice");
        }
        static void Main(string[] args)
        {
            IceCream i = new Mastani();
            i.Eat();
            Juice j = new Mastani();
            j.Drink();
        }
    }


}
