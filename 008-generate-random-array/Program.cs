using System;
using System.ComponentModel;
using System.Collections.Generic;


namespace _008_generate_random_array
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Random r = new Random();
            int valSize = 30;
            int[] array = new int[valSize];
            for(int i = 0; i < valSize; i++)
            {
            array[i] = r.Next(0,array.Length);
            Console.WriteLine("random: "+ array[i]);
            }
        }
    }
}
