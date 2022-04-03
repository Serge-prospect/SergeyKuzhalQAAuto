using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class PmEmployee : Employee, IAssignTask
    {
        public string Speciality { get; } = "PM";
        public PmEmployee(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Manage team.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName}\t{Speciality}");
        }

        public void AssignTask()
        {
            Console.WriteLine("Assign task:");
        }
    }
}
