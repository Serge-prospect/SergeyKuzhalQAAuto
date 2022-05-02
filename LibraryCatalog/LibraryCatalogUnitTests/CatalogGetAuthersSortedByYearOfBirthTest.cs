using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCatalog;
using System.Collections.Generic;
using System;

namespace LibraryCatalogUnitTests
{
    [TestClass]
    public class CatalogGetAuthersSortedByYearOfBirthTest
    {           
        const string _expectedIntroMessage = "Authors sorted by year of birth:";
        Author _author1 = new Author("FName1", "LName1", new DateTime(1801, 1, 1));
        Author _author2 = new Author("FName2", "LName2", new DateTime(1802, 1, 1));
        Author _author3 = new Author("FName3", "LName3", new DateTime(1803, 1, 1));
        const int _expectedListCount = 3;
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
                            new Author("FName3", "LName3", new DateTime(1803, 1, 1)),       // _author3
                            new Author("FName2", "LName2", new DateTime(1802, 1, 1))        // _author2
                            
                        }
                    ),
                    new Book
                    (
                        "Title2",
                        new DateTime(1992, 02, 22),
                        new List<Author>()
                        {
                            new Author("FName3", "LName3", new DateTime(1803, 1, 1)),       // _author3
                            new Author("FName1", "LName1", new DateTime(1801, 1, 1))        // _author1
                        }
                    )
                }
            );
        
        [TestMethod]
        public void AuthersSortedByYearOfBirth()
        {
            Catalog.GetAuthersSortedByYearOfBirth(_libraryCatalog, out List<Author> actualResult, out string _introMessage);            
            Assert.IsTrue
                (
                    new CompareAuthors().Equals(_author1, actualResult[0]) &&
                    new CompareAuthors().Equals(_author2, actualResult[1]) &&
                    new CompareAuthors().Equals(_author3, actualResult[2]) &&
                    _expectedListCount == actualResult.Count
                );
        }

        [TestMethod]
        public void IntroMessage()
        {
            Catalog.GetAuthersSortedByYearOfBirth(_libraryCatalog, out List<Author> _authors, out string actualResult);
            Assert.AreEqual(_expectedIntroMessage, actualResult);
        }        
    }
}
