using System;

namespace _003_pointer
{
   unsafe public class Pointer
    {
         public unsafe void Method()  
    {  
        int gold = 999;  
        int* pointer = &gold;   
        Console.WriteLine((int)pointer);  
        Console.WriteLine(*pointer);  
    }  
    }
}