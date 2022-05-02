using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryCatalog
{
    public class CompareListsOfAuthors : IEqualityComparer<List<Author>>
    {
        public bool Equals(List<Author> x, List<Author> y)
        {
            int _matchCounter = 0;
            if (x.Count == y.Count)
            {
                foreach (var yAuthor in y)
                {
                    if(x.Contains(yAuthor, new CompareAuthors()))
                        _matchCounter++;
                }
            }
            return _matchCounter == x.Count;
        }
        public int GetHashCode(List<Author> obj)
        {
            int _listHashCode = 0;            
            foreach (var _author in obj)
            {
                int _authorHashCode = new CompareAuthors().GetHashCode(_author);
                _listHashCode =+ _authorHashCode;
            }
            return _listHashCode;
        }
    }
}
