using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCatalog;
using System.Collections.Generic;
using System;

namespace LibraryCatalogUnitTests
{
    [TestClass]
    public class CatalogGetAllAuthorsTest
    {           
        const string _expectedIntroMessage = "All authors:";
        Author _author1 = new Author("FName1", "LName1", new DateTime(1801, 1, 1));
        Author _author2 = new Author("FName2", "LName2", new DateTime(1801, 1, 1));
        Author _author3 = new Author("FName3", "LName3", new DateTime(1801, 1, 1));
        Author _author4 = new Author("FName4", "LName4", new DateTime(1801, 1, 1));
        Author _author5 = new Author("FName4", "LName4", new DateTime(1805, 1, 1));
        Author _author6 = new Author("FName4", "LName4", new DateTime(1801, 6, 1));
        Author _author7 = new Author("FName4", "LName4", new DateTime(1801, 1, 7));
        const int _expectedListCount = 5;
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
                            new Author("FName2", "LName2", new DateTime(1801, 1, 1)),       // _author2
                            new Author("FName1", "LName1", new DateTime(1801, 1, 1)),       // _author1
                            new Author("FName3", "LName3", new DateTime(1801, 1, 1))        // _author3
                        }
                    ),
                    new Book
                    (
                        "Title2",
                        new DateTime(1992, 02, 22),
                        new List<Author>()
                        {
                            new Author("FName2", "LName2", new DateTime(1801, 1, 1)),       // _author2
                            new Author("FName1", "LName1", new DateTime(1801, 1, 1)),       // _author1
                            new Author("FName4", "LName4", new DateTime(1801, 1, 1)),       // _author4
                            new Author("FName4", "LName4", new DateTime(1805, 1, 1)),       // _author5
                            new Author("FName4", "LName4", new DateTime(1801, 6, 1)),       // _author6
                            new Author("FName4", "LName4", new DateTime(1801, 1, 7))        // _author7
                        }
                    )
                }
            );
        
        [TestMethod]
        public void AllAuthors()
        {
            Catalog.GetAllAuthors(_libraryCatalog, out List<Author> actualResult, out string _introMessage);            
            Assert.IsTrue
                (
                    new CompareAuthors().Equals(_author1, actualResult[0]) &&
                    new CompareAuthors().Equals(_author2, actualResult[1]) &&
                    new CompareAuthors().Equals(_author3, actualResult[2]) &&
                    new CompareAuthors().Equals(_author4, actualResult[3]) &&
                    new CompareAuthors().Equals(_author5, actualResult[4]) &&
                    !(actualResult.Contains(_author6) || actualResult.Contains(_author7)) &&
                    _expectedListCount == actualResult.Count
                );
        }

        [TestMethod]
        public void IntroMessage()
        {
            Catalog.GetAllAuthors(_libraryCatalog, out List<Author> _authors, out string actualResult);
            Assert.AreEqual(_expectedIntroMessage, actualResult);
        }        
    }
}
