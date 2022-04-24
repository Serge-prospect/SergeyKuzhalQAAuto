using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var libraryCatalog = new Catalog
            (
                new List<Book>
                {
                    new Book
                    (
                        "Title1",
                        new DateTime(1991, 01, 21),
                        new List<Author>()
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800,1,1)),
                            new Author("FName1.1", "LName1.1", new DateTime(1811,1,1)),
                            new Author("FName1.2", "LName1.2", new DateTime(1812,1,2))                            
                        }
                    ),
                    new Book
                    (
                        "Title2",
                        new DateTime(1992, 02, 22),
                        new List<Author>
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800,1,1)),
                            new Author("FName2.1", "LName2.1", new DateTime(1821,2,1)),
                            new Author("FName2.2", "LName2.2", new DateTime(1822,2,1))
                        }
                    ),
                    new Book
                    (
                        "Title3",
                        new DateTime(1993, 03, 23),
                        new List<Author>
                        {
                            new Author("FName3.1", "LName3.1", new DateTime(1831,3,1)),
                            new Author("FName3.2", "LName3.2", new DateTime(1832,3,2))
                        }
                    ),
                    new Book
                    (
                        "Title4",
                        new DateTime(1994, 04, 24),
                        new List<Author>
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800,1,1)),
                            new Author("FName4.1", "LName4.1", new DateTime(1641,4,1)),
                            new Author("FName4.2", "LName4.2", new DateTime(1741,4,1))
                        }
                    ),
                }
            );

            List<Book> filteredBooks;
            List<Author> filteredAuthors;
            string introMessage;

            // Method 1 - Get list of Books sorted by Titles
            Catalog.GetBooksSortedByTitle(libraryCatalog, out filteredBooks, out introMessage);
            Catalog.DisplayBooks(filteredBooks, introMessage);

            // Method 2 - Get list of Authors from the catalog
            Catalog.GetAllAuthors(libraryCatalog, out filteredAuthors, out introMessage);            
            Catalog.DisplayAuthors(filteredAuthors, introMessage);

            // Method 3 - Get list of Books by a specific Author
            //  And published after a specific year
            var bIndex = 0;
            var aIndex = bIndex;
            var specificAuthorFName = libraryCatalog.ListOfBooks[bIndex].Authors[aIndex].FName;
            var specificAuthorLName = libraryCatalog.ListOfBooks[bIndex].Authors[aIndex].LName;
            var specificYear = libraryCatalog.ListOfBooks[bIndex].PubDate.Year;

            Catalog.GetBooksByAuthorAndGtPubDateYear
                (libraryCatalog, specificAuthorFName, specificAuthorLName, specificYear, out filteredBooks, out introMessage);
            Catalog.DisplayBooks(filteredBooks, introMessage);

            // Method 4 - Get list of Authors Sorted by year of Birth
            Catalog.GetAuthersSortedByYearOfBirth(libraryCatalog, out filteredAuthors, out introMessage);
            Catalog.DisplayAuthors(filteredAuthors, introMessage);
        }
    }
}
