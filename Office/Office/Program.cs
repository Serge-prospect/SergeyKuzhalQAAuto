using System;
using System.Collections.Generic;

namespace Office
{
    class Program
    {
        static void Main(string[] args)
        {
            var interfaces = new Dictionary<int, string>()
            {
                [1] = "IAssignTask",
                [2] = "IReviewCode",
                [3] = "IWriteCode",
            };

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

            //Display Employees who can Write Code
            DisplayByInterface<IAssignTask>(officeEmployees, interfaces[1]);

            //Display Employees who can Review Code
            DisplayByInterface<IReviewCode>(officeEmployees, interfaces[2]);

            //Display Employees who can Assign Task
            DisplayByInterface<IWriteCode>(officeEmployees, interfaces[3]);

            void DisplayByInterface<TInterface>(List<Employee> employees, string interfaceName)
            {
                bool isIntroTextDisplayed = false;
                foreach (Employee currentEmployee in employees)
                {
                    if (currentEmployee is TInterface)
                    {
                        if (isIntroTextDisplayed == false)
                        {
                            DisplayIntroText(currentEmployee, interfaceName);
                            isIntroTextDisplayed = true;
                        }
                        currentEmployee.PrintEmployeeInfo();
                    }
                }
            }

            void DisplayIntroText(Employee employee, string interfaceName)
            {
                if (interfaceName == GetEmployeeInterfaceByDictionaryName(employee, interfaces[1]))
                    (employee as IAssignTask).AssignTask();
                else if (interfaceName == GetEmployeeInterfaceByDictionaryName(employee, interfaces[2]))
                    (employee as IReviewCode)?.ReviewCode();
                else if (interfaceName == GetEmployeeInterfaceByDictionaryName(employee, interfaces[3]))
                    (employee as IWriteCode)?.WriteCode();
            }

            string GetEmployeeInterfaceByDictionaryName(Employee employee, string dictionaryInterface)
            {
                return employee.GetType().GetInterface(dictionaryInterface)?.Name;
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
