using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class DevTeamLead : Employee, IWriteCode, IReviewCode, IAssignTask
    {
        public string Speciality { get; } = "Dev Team Lead";
        public DevTeamLead(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Manage Dev team.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName}\t{Speciality}");
        }

        public void WriteCode()
        {
            Console.WriteLine("Write code:");
        }

        public void ReviewCode()
        {
            Console.WriteLine("Review code:");
        }

        public void AssignTask()
        {
            Console.WriteLine("Assign task:");
        }
    }
}
