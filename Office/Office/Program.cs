using System;
using System.Collections.Generic;

namespace Office
{
    class Program
    {
        static void Main(string[] args)
        {
            var officeEmployees = new List<Employee>()
            {
                new QaEmployee("Caly", "Brown"),
                new DevEmployee("Mary", "Jane"),
                new DevTeamLead("Sam", "White"),
                new QaTeamLead("Jack", "Black"),
                new QaAutomationEmployee("Jackue", "Beruenaute"),
                new QaAutomationTeamLead("Steven", "Seagull"),
                new BaEmployee("Grace", "Period"),
                new PmEmployee("Mark", "Overnight"),
                new QaEmployee("Peter", "Parker")
            };

            //Employees who can Write Code
            Console.WriteLine("Write code:");
            foreach (Employee currentEmployee in officeEmployees)
            {
                if (currentEmployee is IWriteCode)                
                    currentEmployee.PrintEmployeeInfo();                
            }

            //Employees who can Review Code
            Console.WriteLine("Review code:");
            foreach (Employee currentEmployee in officeEmployees)
            {
                if (currentEmployee is IReviewCode)
                    currentEmployee.PrintEmployeeInfo();
            }

            //Employees who can Assign Task
            Console.WriteLine("Assign task:");
            foreach (Employee currentEmployee in officeEmployees)
            {
                if (currentEmployee is IAssignTask)
                    currentEmployee.PrintEmployeeInfo();
            }
        }
    }
}
