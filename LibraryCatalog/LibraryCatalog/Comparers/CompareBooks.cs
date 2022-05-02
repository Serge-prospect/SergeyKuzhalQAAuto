using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    public class CompareBooks : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            return ((x.Title + x.PubDate.Year).Equals(y.Title + y.PubDate.Year) &&
                    new CompareListsOfAuthors().Equals(x.Authors, y.Authors));
        }
        public int GetHashCode(Book obj)
        {
            return (obj.Title + obj.PubDate.Year).GetHashCode() +
                    new CompareListsOfAuthors().GetHashCode(obj.Authors);
        }
    }
}
