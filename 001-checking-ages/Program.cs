using System;

namespace _001_checking_ages
{
    class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person(24);
           Person p2 = new Person(20);
           AgeChecking("p1:",p1.Age);
           AgeChecking("p2:",p2.Age);

           System.Console.WriteLine(p1.Age);

        }

        static void AgeChecking(string s,int age)
        {
             int passAge = 20;
             if(passAge >= age)
             {
                 Console.WriteLine(s+" you shall not pass");
             }
             else
             {
                  Console.WriteLine(s+" welcom!");
             }
        }
    }
}
