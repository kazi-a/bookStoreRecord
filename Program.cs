using System;

namespace bookStoreRecord 
{
    public record Bookstore(int ID, string Title, string Author, double Price); // Using positional syntax

    class Program
    {
        static void Main(string[] args)
        {
            Bookstore book1 = new(1, "The Great Gatsby", "F. Scott Fitzgerald", 10.99); // Using positional syntax
            Bookstore book2 = new(2, "To Kill a Mockingbird", "Harper Lee", 12.50); // Using positional syntax
            Bookstore book3 = new(3, "1984", "George Orwell", 9.99); // Using positional syntax

            DisplayBookInformation(book1);
            DisplayBookInformation(book2);
            DisplayBookInformation(book3);
        }

        static void DisplayBookInformation(Bookstore book)
        {
            Console.WriteLine($"ID: {book.ID}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Price: ${book.Price}");
            Console.WriteLine();
        }
    }
}
