using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    class CompareAuthorByAuthorFullName : IEqualityComparer<Author>
    {
        public bool Equals(Author x, Author y)
        {
            return (x.FName + x.LName).Equals(y.FName + y.LName);
        }
        public int GetHashCode(Author obj)
        {
            return (obj.FName + obj.LName).GetHashCode();
        }
    }
}
