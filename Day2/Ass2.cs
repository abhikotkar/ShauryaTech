using System;

namespace ShauryaTech.Day2
{
    class Ass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /*1.	 WAP which throws IndexOutOfRangeException. In the console, observe the stack trace and the line number from
               where the Exception is thrown*/

    class IndexOutOfBound : ApplicationException
    {
        public IndexOutOfBound(string msg) : base(msg)
        {

        }
        public IndexOutOfBound()
        {

        }
    }

    class PasswordException1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string name = Console.ReadLine();

            if (name.Length > 5)
            {
                try
                {
                    throw new IndexOutOfBound("The length of number is grater then 5");
                }
                catch (IndexOutOfBound i)
                {
                    Console.WriteLine(i.Message);
                }
            }
            else
                Console.WriteLine("Login Successfully");
            Console.WriteLine("End");
        }
    }

    //2.	WAP to use catch / handle the IndexOutOfRangeException exception.

    class Indexout
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("ram"[6]);
            }

            catch (IndexOutOfRangeException se)//handle all exceptions except null ref exception
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Wrong Input");
            }
        }
    }

    /*3.	WAP to catch multiple exceptions.i.e IndexOutOfRangeException, NullReferenceException
and DivideByZeroException.*/

    class AllException
    {
        static string str = "hgf";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(str.ToUpper());
            }
            catch (NullReferenceException f)
            {
                Console.WriteLine(f.Message);
            }
            try
            {
                Console.WriteLine("Enter two values");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine("sum=" + (a + b));
                    Console.WriteLine("Division=" + a / b);
                    Console.WriteLine("Enter number");
                    int c = int.Parse(Console.ReadLine());
                }
                catch (DivideByZeroException d)
                {
                    Console.WriteLine(d.Message);
                }
            }
            catch (FormatException f1)
            {
                Console.WriteLine(f1.Message);
            }
            try
            {
                Console.WriteLine("Amey"[6]);
            }
            catch (IndexOutOfRangeException f2)
            {
                Console.WriteLine(f2.Message);
            }






        }
    }

    class Animal
    {
        static string str="gst";

        public virtual void Type()
        {
            
                Console.WriteLine(str.ToUpper());
            
            
        }
    }

    class Dog : Animal
    {
        string str1;
        public override void Type()
        {
            try
            {
                Console.WriteLine(str1.ToUpper());
            }
            catch(NullReferenceException s)
            {
                Console.WriteLine(s.Message);
            }
        }
    }
    class Babydog : Dog
    {
        string str2;
        public override void Type()
        {
            Console.WriteLine(str2.ToUpper());
        }
        static void Main(string[] args)
        {
            Animal a = new Dog();
            /* try
             {
                 a.Type();
             }
             catch (NullReferenceException n)
             {
                 Console.WriteLine(n.Message);
             }*/
            a.Type();
        }
    }
}
