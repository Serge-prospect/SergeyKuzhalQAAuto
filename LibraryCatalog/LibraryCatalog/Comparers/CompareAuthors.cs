using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    public class CompareAuthors : IEqualityComparer<Author>
    {
        public bool Equals(Author x, Author y)
        {
            return (x.FName + x.LName + x.DoB.Year).Equals(y.FName + y.LName + y.DoB.Year);
        }
        public int GetHashCode(Author obj)
        {
            return (obj.FName + obj.LName + obj.DoB.Year).GetHashCode();
        }
    }
}
