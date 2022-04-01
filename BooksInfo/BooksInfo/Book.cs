using System;
using System.Collections.Generic;
using System.Text;

namespace BooksInfo
{
    class Book
    {
        public string Id { get; } = GetIdType1();
        public string Title { get; set; } = "No title";
        public int Pages { get; set; }

        public Book(string title, int pages) : this()
        {
            Title = title;
            Pages = pages;            
        }
        public Book(string title) : this()
        {
            Title = title;
        }
        public Book(int pages) : this()
        {
            Pages = pages;
        }
        public Book()
        { }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"ID: {Id}\tTitle: {Title}\tPages: {Pages}");
        }

        // Get a unique ID (Type1)
        static int idCounter = 1;
        static string GetIdType1()
        {
            string uniqueId = idCounter.ToString();
            idCounter++;
            return uniqueId;
        }

        // Another variant of a unique ID (Type2)
        static string GetIdType2() => Guid.NewGuid().ToString();
    }
}
