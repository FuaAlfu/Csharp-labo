using System;

namespace _009_two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int valSize = 30;
            int[,] array = new int[valSize,valSize];
            for(int i = 0; i < valSize; i++)
            {
                for(int j = 0; j < valSize; j++)
                {
                      array[i,j] = r.Next(0,array.Length);
                      Console.WriteLine("random: "+ array[i,j]);
                }
             Console.WriteLine(" ");
            }
        }
    }
}
