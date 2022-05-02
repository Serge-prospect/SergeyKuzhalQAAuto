using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCatalog;
using System.Collections.Generic;
using System;

namespace LibraryCatalogUnitTests
{
    [TestClass]
    public class CatalogGetBooksByAuthorAndGtPubDateYearTest
    {
        const string _authorFName = "Tomas";
        const string _authourLName = "Hardy";
        const int _pubDateYear = 1992;
        string _expectedIntroMessage = "Books of " + _authorFName + " " + _authourLName + " published after " + _pubDateYear + " year:";
        const int _expectedListCount = 1;
        Catalog _libraryCatalog = new Catalog
            (
                new List<Book>()
                {
                    new Book
                    (
                        "Title1",
                        new DateTime(1991, 01, 21),
                        new List<Author>()
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800, 1, 1)),
                            new Author("FName1.1", "LName1.1", new DateTime(1811, 1, 1)),
                            new Author("FName1.2", "LName1.2", new DateTime(1812, 1, 2))
                        }
                    ),
                    new Book
                    (
                        "Title2",
                        new DateTime(1992, 02, 22),
                        new List<Author>()
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800, 1, 1)),
                            new Author("FName2.1", "LName2.1", new DateTime(1821, 2, 1)),
                            new Author("FName2.2", "LName2.2", new DateTime(1822, 2, 2))
                        }
                    ),
                    new Book
                    (
                        "Title3",
                        new DateTime(1993, 03, 23),
                        new List<Author>()
                        {
                            new Author("FName3.1", "LName3.1", new DateTime(1831, 3, 1)),
                            new Author("FName3.2", "LName3.2", new DateTime(1832, 3, 2))
                        }
                    ),
                    new Book
                    (
                        "Title4",
                        new DateTime(1994, 04, 24),
                        new List<Author>()
                        {
                            new Author("Tomas", "Hardy", new DateTime(1800, 1, 1)),
                            new Author("FName2.1", "LName2.1", new DateTime(1841, 4, 1)),
                            new Author("FName2.2", "LName2.2", new DateTime(1842, 4, 2))
                        }
                    )
                }
            );

        [TestMethod]
        public void BooksByAuthorAndGtPubDateYear()
        {
            Catalog.GetBooksByAuthorAndGtPubDateYear
                (_libraryCatalog, _authorFName, _authourLName, _pubDateYear, out List<Book> actualResult, out string _introMessage);
            Assert.IsTrue
                (
                    "Title4" == actualResult[0].Title &&
                    _expectedListCount == actualResult.Count
                );
        }

        [TestMethod]
        public void IntroMessage()
        {
            Catalog.GetBooksByAuthorAndGtPubDateYear
                 (_libraryCatalog, _authorFName, _authourLName, _pubDateYear, out List<Book> _books, out string actualResult);
            Assert.AreEqual(_expectedIntroMessage, actualResult);
        }
    }
}
