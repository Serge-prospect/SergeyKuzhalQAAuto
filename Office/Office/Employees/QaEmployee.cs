using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class QaEmployee : Employee
    {
        public string Speciality { get; } = "QA Employee";
        public QaEmployee(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Run test suites.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName,-10}\t{Speciality}");
        }
    }
}
