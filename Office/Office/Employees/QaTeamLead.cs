using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class QaTeamLead : Employee, IAssignTask
    {
        public string Speciality { get; } = "QA Team Lead";
        public QaTeamLead(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Work()
        {
            Console.WriteLine("Manage QA team.");
        }

        public override void PrintEmployeeInfo()
        {
            Console.WriteLine($"Tax ID: {TaxId}\tFull name: {FirstName} {LastName,-10}\t{Speciality}");
        }

        public void AssignTask()
        {
            Console.WriteLine("Assign task:");
        }
    }
}
