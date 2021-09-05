using System;

namespace _004_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
           int factorial = 0;
           factorial = Factorial(5);
           Console.WriteLine(factorial);
        }

        private static int Factorial(int f)
        {
            //Exit condition..
           if(f == 1)
           return 1;
           return f *  Factorial(f - 1);
        }
    }
}
