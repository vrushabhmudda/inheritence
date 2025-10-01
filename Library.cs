using System;
using System.Collections.Generic;

namespace USFLibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<Person> patrons;

        public Library()
        {
            books = new List<Book>();
            patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            patrons.Add(patron);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (Person patron in patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
            }
            Console.WriteLine();
        }

        public Book FindBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
