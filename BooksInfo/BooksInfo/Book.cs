using System;
using System.Collections.Generic;
using System.Text;

namespace BooksInfo
{
    class Book
    {
        public string Id { get; }        
        public string Title { get; set; }
        public int Pages { get; set; }
        public Book(string id)
        {
            Id = id;
            Title = "No title";
            Pages = 0;            
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"ID: {Id}     Title: {Title}     Pages: {Pages}");
        }
    }
}
