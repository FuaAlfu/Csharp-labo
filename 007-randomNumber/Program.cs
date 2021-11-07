using System;
using System.Collections.Generic;

namespace _007_randomNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
             Console.WriteLine(RandomNumber(0,256));
        }
        
         // generates a random number within a range.
            public static int RandomNumber(int min, int max)  
            {  
               Random random = new Random();
               return random.Next(min, max);  
            }  
    }
}
