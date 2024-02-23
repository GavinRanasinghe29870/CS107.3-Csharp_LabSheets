using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_Q5
{


    class LibraryBook
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }


        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }


        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' by {Author} is not available for borrowing.");
                Console.ReadLine();

            }
        }
    }

    class Program
    {
        static void Main()
        {

            LibraryBook book1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true);
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", false);
            LibraryBook book3 = new LibraryBook("1984", "George Orwell", true);


            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();


            Console.WriteLine("\nUpdated Library Status:");
            Console.WriteLine($"Book '{book1.Title}' by {book1.Author} is {(book1.Available ? "available" : "not available")}.");
            Console.WriteLine($"Book '{book2.Title}' by {book2.Author} is {(book2.Available ? "available" : "not available")}.");
            Console.WriteLine($"Book '{book3.Title}' by {book3.Author} is {(book3.Available ? "available" : "not available")}.");
            Console.ReadLine();


        }
    }
