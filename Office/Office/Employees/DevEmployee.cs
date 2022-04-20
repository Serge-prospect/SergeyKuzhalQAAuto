using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class DevEmployee : Employee, IWriteCode
    {
        public string Speciality { get; } = "Dev";
        public DevEmployee(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Make red eyes.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName,-10}\t{Speciality}");
        }

        public void WriteCode()
        {
            Console.WriteLine("Write code:");
        }
    }
}
