using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryCatalog
{
    class Catalog
    {
        public List<Book> ListOfBooks { get; }
        public Catalog(List<Book> books)
        {
            ListOfBooks = books;
        }

        // Method 1 - Get list of Books sorted by Titles
        public static void GetBooksSortedByTitle(in Catalog _catalog, out List<Book> _books, out string _introMessage)
        {
            _introMessage = "Books sorted by title:";
            _books = _catalog.ListOfBooks
                            .OrderBy(b => b.Title).ToList();
        }

        // Method 2 - Get list of Authors from the catalog
        public static void GetAllAuthors(in Catalog _catalog, out List<Author> _authors, out string _introMessage)
        {
            _introMessage = "All authors:";
            _authors = _catalog.ListOfBooks
                            .SelectMany(b => b.Authors)
                            .Distinct(new CompareAuthorByAuthorFullName())
                            .OrderBy(a => a.FName + a.LName).ToList();
        }

        // Method 3 - Get list of Books by a specific Author
        //  And published after a specific year
        public static void GetBooksByAuthorAndGtPubDateYear
            (Catalog _catalog, string _authorFName, string _authourLName, int _pubDateYear, out List<Book> _books, out string _introMessage)
        {
            _introMessage = "Books of " + _authorFName + " " + _authourLName + " published after " + _pubDateYear + " year:";
            _books = _catalog.ListOfBooks
                            .Where(b => b.Authors
                                            .Where(a => ((a.FName + a.LName) == (_authorFName + _authourLName))).Count() != 0)
                            .Where(b => b.PubDate.Year > _pubDateYear).ToList();
        }

        // Method 4 - Get list of Authors Sorted by year of Birth
        public static void GetAuthersSortedByYearOfBirth(in Catalog _catalog, out List<Author> _authors, out string _introMessage)
        {
            _introMessage = "Authors sorted by year of birth:";
            _authors = _catalog.ListOfBooks
                        .SelectMany(b => b.Authors)
                        .Distinct(new CompareAuthorByAuthorFullName())
                        .OrderBy(a => a.DoB.Year).ToList();
        }

        // Display Books
        public static void DisplayBooks(List<Book> _books, string _introMessage)
        {
            if (_introMessage != null)
                Console.WriteLine($"> > > {_introMessage}");
            foreach (var _book in _books)
            {
                Console.WriteLine("Book:");
                Console.WriteLine($"{"ID:",-34}\t{"Title:",-10}\t{"Published Date:"}");
                Console.WriteLine($"{_book.ID}\t{_book.Title,-10}\t{_book.PubDate.Year.ToString()}");
                DisplayAuthors(_book.Authors, null);                
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.WriteLine();
        }

        // Display Authors
        public static void DisplayAuthors(List<Author> _authors, string _introMessage)
        {
            if (_introMessage != null)
                Console.WriteLine($"> > > {_introMessage}");
            else Console.WriteLine("Authors:");
            Console.WriteLine($"{"First Name:",-10}\t{"Last Name:",-10}\t{"Date of Birth:"}");
            foreach (var _author in _authors)
                Console.WriteLine($"{_author.FName,-10}\t{_author.LName,-10}\t{_author.DoB.Year.ToString()}");
            Console.WriteLine();
        }
    }
}
