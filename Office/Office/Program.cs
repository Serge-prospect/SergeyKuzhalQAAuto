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

            //Sort Employees            
            string sortIntroText;
            string GetSortIntroText(string sortType)
            {
                string text = "Sorted by " + sortType + ":";
                return text;
            }
            void DisplayEmployees()
            {
                foreach (Employee currentEmployee in officeEmployees)
                    currentEmployee.PrintEmployeeInfo();
            }
                        
            //Sort Employees by First Name
            sortIntroText = GetSortIntroText(CompareByFirstName.sortType);
            officeEmployees.Sort(new CompareByFirstName());
            Console.WriteLine(sortIntroText);
            DisplayEmployees();

            //Sort Employees by Tax ID
            sortIntroText = GetSortIntroText(CompareByTaxId.sortType);
            officeEmployees.Sort(new CompareByTaxId());            
            Console.WriteLine(sortIntroText);
            DisplayEmployees();

            //Sort Employees by Full Name Length
            sortIntroText = GetSortIntroText(CompareByFullNameLength.sortType);
            officeEmployees.Sort(new CompareByFullNameLength());
            Console.WriteLine(sortIntroText);
            DisplayEmployees();

            //Sort Employees by Task Assigners and their Last Name then others
            sortIntroText = GetSortIntroText(CompareByAssignTaskAndLastName.sortType);
            officeEmployees.Sort(new CompareByAssignTaskAndLastName());
            Console.WriteLine(sortIntroText);
            DisplayEmployees();            
        }        
    }
}
