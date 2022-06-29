using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTech.Day6_AND_Day7
{

    //single ref delegate
    public delegate void Mydele(string name, string msg);

    public delegate int Mydele1(int n);
    class Deligates
    {
        static void Show(string name, string msg)
        {
            Console.WriteLine("Welcome " + name + "," + msg);
        }

        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }
        static void Main(string[] args)
        {
            Mydele d1 = Deligates.Show;
            d1("Amey", "Good Evening");

            Mydele1 d2 = Deligates.Factorial;
            Console.WriteLine(d2(5));
        }
    }

    //multi ref delegate

    public delegate void Mydele2(int a, int b);
    class Deligates1
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("Substraction=" + (a - b));
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("Multiplication=" + (a * b));
        }

        static void Main(string[] args)
        {
            Deligates1 d3 = new Deligates1();
            Mydele2 d1 = d3.add;
            d1 += d3.sub;
            d1 += d3.mul;

            d1(10, 5);

            d1 -= d3.sub;
            d1(10, 4);

        }
    }



    public delegate void Mydele3(int a, int b);
    public delegate int Mydele4(int a, int b);
    class Ananomusdelegate
    {
        static void Main(string[] args)
        {
            //ananomous function
            Mydele3 d1 = delegate (int a, int b)
              {
                  Console.WriteLine("Addition is " + (a + b));
              };
            d1(10, 5);

            //Lambda expresion
            Mydele3 d2 = (a, b) => Console.WriteLine("Lambda expresion Addition:" + (a - b));
            d2 += (a, b) => Console.WriteLine("Multiplication:" + (a * b));
            d2(51, 6);

            Mydele4 md = (a, b) =>
              {
                  return a + b;
              };
            Console.WriteLine(md(10, 5));

            Mydele4 md1 = (a, b) => a * b;
            Console.WriteLine(md1(45, 12));
        }
    }

    //Predefind deligates

    //1.Funk<all type parameters,return type>  -  funk is used when function return any type of value except only bool datatype

    //2.Action<all type parameters>  -  action used when function has no return value means return type is void.

    //3.Predicate<all type parameters>   -   predicate used when return only bool type of value.
    class Predefineddelegates
    {
        static int Add(int a, float b, long c)
        {
            return (int)(a + b + c);
        }

        static void Sub(int a, float b, long c)
        {
            Console.WriteLine("Substraction is "+(int)(a + b + c));
        }

        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Func<int, float, long, int> f1 = Add;
            int r=f1(4, 5.1f, 64l);
            Console.WriteLine("Addition is "+r);
            Action<int, float, long> f2 = Sub;
           f2(4,5.2f,54l);
            Predicate<int> f3 = isEven;
            Console.WriteLine("Number is Even =>"+f3(63));
        }
    }

    //use of callback function

    class AA
    {
        static void Filter(List<int> l2,Predicate<int> p1)
        {
            foreach(int ele in l2)
            {
                bool b = p1(ele);
                if(b==true)
                    Console.WriteLine(ele);
            }
        }
        static void Main(string[] args)
        {
            List<int> li = new List<int>() { 12, 56, 4, 548, 55, 585, 5, 8, 89, 45, 69 };
            List<int> l1 = new List<int>();
/*
            foreach (int va in li)
            {
                if (va % 2 == 0)
                {
                    l1.Add(va);
                }
            }
            foreach (int va1 in l1)
            {
                Console.WriteLine(va1);
            }*/

            List<int> l3 = li.FindAll((a) => a % 2 == 0);
            foreach (int v in l3)
            {
                Console.WriteLine(v);
            }

        }
    }
}
