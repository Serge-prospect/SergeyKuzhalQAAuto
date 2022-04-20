using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class CompareByFullNameLength : IComparer<Employee>
    {
        public const string sortType = "Full Name Length";
        public int Compare(Employee x, Employee y)
        {
            return (x.FirstName + x.LastName).Length - (y.FirstName + y.LastName).Length;
        }
    }
}
