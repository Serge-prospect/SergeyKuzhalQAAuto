using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class BaEmployee : Employee
    {
        string Speciality { get; } = "BA";
        public BaEmployee(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Work with requirements.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName}\t{Speciality}");
        }
    }
}
