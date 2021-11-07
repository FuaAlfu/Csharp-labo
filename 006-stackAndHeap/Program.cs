using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _006_stackAndHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book b1 = new Book();
            {
                BookDescription = "fantasy and glancy";
                BookTitle = "king's drink";
                PageNumber = 221;
            };

            Book b2 = b1;

            Console.WriteLine(b1.Read());
            Console.WriteLine(b2.Read());
            Console.WriteLine("uu");
        }
    }

    class Book
    {
      public  string BookDescription {get; set;}
      public  string BookTitle {get; set;}
      public  int PageNumber {get; set;}

        public string Read()
        {
            return String.Format("{0}: {1}, pp. {2}", BookDescription, BookTitle,PageNumber);
        }

    }

    
}
