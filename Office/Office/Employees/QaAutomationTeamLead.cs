using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class QaAutomationTeamLead : Employee, IWriteCode, IReviewCode, IAssignTask
    {
        public string Speciality { get; } = "QA Automation Team Lead";
        public QaAutomationTeamLead(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Manage QA automation team.");
        }

        public void WriteCode()
        {
            Console.WriteLine("Write code:");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName,-10}\t{Speciality}");
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
