using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCatalog;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LibraryCatalogUnitTests
{
    [TestClass]
    public class CatalogAddNewBookTest
    {
        // Existing Books in the catalog
        Book _existingBook1 = new Book
            (
                "Title1",
                new DateTime(1990, 1, 1),
                new List<Author>()
                {
                    new Author("FName1", "LName1", new DateTime(1801, 1, 1)),
                    new Author("FName2", "LName2", new DateTime(1802, 1, 1))
                }
            );
        Book _existingBook2 = new Book
            (
                "Title2",
                new DateTime(1990, 1, 1),
                new List<Author>()
                {
                    new Author("FName3", "LName3", new DateTime(1803, 1, 1)),
                    new Author("FName4", "LName4", new DateTime(1804, 1, 1))
                }
            );

        // New valid Books to be added to the catalog
        Book _newBookNewTitle = new Book
            (
                "Title3",
                new DateTime(1990, 1, 1),
                new List<Author>()
                {
                    new Author("FName3", "LName3", new DateTime(1803, 1, 1)),
                    new Author("FName4", "LName4", new DateTime(1804, 1, 1))
                }
            );
        Book _newBookNewPubDate = new Book
            (
                "Title2",
                new DateTime(2000, 1, 1),
                new List<Author>()
                {
                    new Author("FName3", "LName3", new DateTime(1803, 1, 1)),
                    new Author("FName4", "LName4", new DateTime(1804, 1, 1))
                }
            );
        Book _newBookNewAuthor = new Book
            (
                "Title2",
                new DateTime(1990, 1, 1),
                new List<Author>()
                {
                    new Author("FName3", "LName3", new DateTime(1803, 1, 1)),
                    new Author("FName4", "LName4", new DateTime(1804, 1, 1)),
                    new Author("FName5", "LName5", new DateTime(1805, 1, 1))
                }
            );

        // New invalid Book (duplicate) to be added to the catalog
        Book _newInvalidBookDuplicateOfBook1 = new Book
            (
                "Title1",
                new DateTime(1990, 1, 1),
                new List<Author>()
                {
                    new Author("FName1", "LName1", new DateTime(1801, 1, 1)),
                    new Author("FName2", "LName2", new DateTime(1802, 1, 1))
                }
            );

        [TestMethod]
        public void AddNewBookNewTitlePositive()
        {
            const int _expectedListCount = 3;
            var _books = new List<Book>() { _existingBook1, _existingBook2 };
            var _libraryCatalog = new Catalog(_books);

            _libraryCatalog.AddNewBook(_newBookNewTitle);
            Assert.IsTrue
                (
                    _books.Contains(_newBookNewTitle, new CompareBooks()) &&
                    _expectedListCount == _books.Count
                );
        }

        [TestMethod]
        public void AddNewBookNewPubDatePositive()
        {
            const int _expectedListCount = 3;
            var _books = new List<Book>() { _existingBook1, _existingBook2 };
            var _libraryCatalog = new Catalog(_books);

            _libraryCatalog.AddNewBook(_newBookNewPubDate);
            Assert.IsTrue
                (
                    _books.Contains(_newBookNewPubDate, new CompareBooks()) &&
                    _expectedListCount == _books.Count
                );
        }

        [TestMethod]
        public void AddNewBookNewAuthorPositive()
        {
            const int _expectedListCount = 3;
            var _books = new List<Book>() { _existingBook1, _existingBook2 };
            var _libraryCatalog = new Catalog(_books);

            _libraryCatalog.AddNewBook(_newBookNewAuthor);
            Assert.IsTrue
                (
                    _books.Contains(_newBookNewAuthor, new CompareBooks()) &&
                    _expectedListCount == _books.Count
                );
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddNewBookDublicateOfBook1Negative()
        {
            const int _expectedListCount = 2;
            var _books = new List<Book>() { _existingBook1, _existingBook2 };
            var _libraryCatalog = new Catalog(_books);

            _libraryCatalog.AddNewBook(_newInvalidBookDuplicateOfBook1);
            Assert.IsTrue(_expectedListCount == _books.Count);
        }
    }
}
