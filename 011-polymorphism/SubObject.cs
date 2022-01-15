using System;

namespace _011_polymorphism
{
    class SubObject: MainObject
    {
        public string Object {get;set;}
    //    public SubObject(string obj)
    //     {
    //         this.Object = obj;
    //     }

        public override int Adding(int a, int b)
        {
            return a + b;
        }
    }
}