using System;

namespace _002_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Name n1 = new Names("998711");
            Name n2 = new Names("991701");

           Console.WriteLine(n2.Name);
           CheckID("m1", n1.Name);
        }

        static void CheckID(string s,string id)
        {
            string idCheck = "998711";
             if(idCheck != id)
             {
                 Console.WriteLine(s+" not pass");
             }
             else
             {
                  Console.WriteLine(s+" welcom!");
             }
        }
    }
}
