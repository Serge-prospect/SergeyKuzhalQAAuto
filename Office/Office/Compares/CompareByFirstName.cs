using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class CompareByFirstName : IComparer<Employee>
    {
        public const string sortType = "First Name";
        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.FirstName, y.FirstName);
        }
    }
}
