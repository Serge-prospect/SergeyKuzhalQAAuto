using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    class CompareBooks : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            return (x.Title + x.PubDate + x.Authors).Equals(y.Title + y.PubDate + y.Authors);
        }
        public int GetHashCode(Book obj)
        {
            return (obj.Title + obj.PubDate + obj.Authors).GetHashCode();
        }
    }
}
