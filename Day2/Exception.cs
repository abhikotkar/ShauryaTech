using System;

namespace ShauryaTech.Day2
{
    class Exception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ExceptionHand
    {
        string name;

        public string Name
        {
           set
           {
                for(int i=0;i<value.Length;i++)
                {
                    if(char.IsDigit(value[i]))
                    {
                        throw new ApplicationException("Invalid Value");
                    }
                }
                name = value;
           }
           

            
        }
        static void Main(string[] args)
        {
            ExceptionHand e = new ExceptionHand();
            e.Name = "dqwe23";
        }
    }

    class ExceptionDemo
    {
        static string name="om";
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine(name.ToUpper());
                Console.WriteLine("om"[6]);
            }
            catch (NullReferenceException r)//null ref
            {
                Console.WriteLine(r.Message);
                Console.WriteLine("Wrong Input");
            }
            catch (SystemException se)//handle all exceptions except null ref exception
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Wrong Input");
            }




            try
            {

                Console.WriteLine("Enter any number:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("try");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Wrong Input");
            }
            catch(NullReferenceException r1)
            {
                Console.WriteLine(r1.Message);
                Console.WriteLine("Wrong Input");
            }
            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Wrong Input");
            }
            for (int i=0;i<10;i++)
                Console.WriteLine(i);
        }
    }


    class DivideException
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine("sum="+(a+b));
                    Console.WriteLine("Division="+a/b);
                    Console.WriteLine("Enter number");
                    int c = int.Parse(Console.ReadLine());//outer  catch also handle inner try exception
                }
                catch(DivideByZeroException d)
                {
                    Console.WriteLine(d.Message);
                }
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
            }
        }
    }

    //exceptions always propogate

    class Excep
    {
        static void add()
        {
            Console.WriteLine("Enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum= "+(a+b));
        }
        static void Main(string[] args)
        {
            try
            {
                add();
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }

    //Custom exception

    class InvalidPassException:ApplicationException
    {
       public InvalidPassException(string msg):base(msg)
        {

        }
        public    InvalidPassException()
        {

        }
    }

    class PasswordException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            if(pass.Length<5)
            {
                try
                {
                    throw new InvalidPassException("The length of password must be grater then 5");
                }
                catch(InvalidPassException i)
                {
                    Console.WriteLine(i.Message);
                }
            }
            else
                Console.WriteLine("Login Successfully");
            Console.WriteLine("End");
        }
    }

}
