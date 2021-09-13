using System;
using System.Collections.Generic;

namespace _005_arrang
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>();
           var nums = new List<int> { 2, 1, 8 };

           numbers.Add(23);
           numbers.Add(13);
           numbers.Add(3);
           numbers.AddRange(nums);

           foreach (int number in numbers)
           {
               Console.WriteLine(number);
           }
           System.Console.WriteLine("---");
           numbers.Sort();
           Console.WriteLine(string.Join(",", numbers));
           

        }
    }
}
