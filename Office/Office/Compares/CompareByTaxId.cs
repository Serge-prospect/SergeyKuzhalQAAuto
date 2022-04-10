using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class CompareByTaxId : IComparer<Employee>
    {
        public const string sortType = "Tax ID";
        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.TaxId, y.TaxId);
        }
    }
}
