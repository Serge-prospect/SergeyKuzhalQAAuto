using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog
{
    public class Author
    {
        public string FName { get; }
        public string LName { get; }
        public DateTime DoB { get; }
        public Author(string fName, string lName, DateTime dateOfBirth)
        {
            FName = fName;
            LName = lName;
            DoB = dateOfBirth;
        }
    }
}
