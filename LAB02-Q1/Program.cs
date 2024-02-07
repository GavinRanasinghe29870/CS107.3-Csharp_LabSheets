using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_Q1
{
    internal class Program
    {
        class Books
        {
            public String Author;
            public String Title;
        }
        static void Main(string[] args)
        {
            Books books = new Books();
            books.Author = "AnitaDesi";
            books.Title = "Village by sea";
            Console.WriteLine("Title: " + books.Title);
            Console.WriteLine("Author: " + books.Author);
            Console.ReadLine();
        }
    }
}
