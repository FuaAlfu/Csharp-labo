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

            MainObject m = new MainObject();
            m = new SubObject();
           Console.WriteLine("adding numbers: "+ m.Adding(number1,number2));
           //System.Console.WriteLine("boo");

            Console.ReadLine();
        }
    }
}
