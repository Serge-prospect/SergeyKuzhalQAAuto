using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class QaAutomationEmployee : Employee, IWriteCode
    {
        public string Speciality { get; } = "QA Automation";
        public QaAutomationEmployee(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Execute auto tests.");
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
