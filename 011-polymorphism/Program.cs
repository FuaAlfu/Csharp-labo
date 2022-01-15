using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace _011_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 33;
            int number2 = 44;

            //------------(override)
            MainObject m = new MainObject();
            m = new SubObject();
           Console.WriteLine("adding numbers: "+ m.Adding(number1,number2));
           //System.Console.WriteLine("boo");

           //-----------(overload)
           Program p = new Program();

           Console.WriteLine(p.Add(number1,number2));
           Console.WriteLine(p.Add(number1,number2,number1));

            Console.ReadLine();
        }

         public int Add(int a, int b)
           {
               return (a + b);
           }

          public int Add(int a, int b, int c)
           {
               return a + b + c;
           }
    }
}
