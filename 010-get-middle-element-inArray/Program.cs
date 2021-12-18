using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace _010_get_middle_element_inArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{11,2,41,97};
            int mid = array[array.Length / 2];
            Console.WriteLine(mid);
        }
    }
}
