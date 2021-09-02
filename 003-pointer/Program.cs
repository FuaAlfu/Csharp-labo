using System;

namespace _003_pointer
{
   unsafe class Program
    {
        static void Main(string[] args)
        {
            /*
            Pointer p = new Pointer();  
            p.Method();    
            */
            int silver = 720;
            int* p; 
            p = &silver;
            Console.WriteLine($"pointer's value is: {*p}");
            Console.ReadLine();
        }
    }
}
