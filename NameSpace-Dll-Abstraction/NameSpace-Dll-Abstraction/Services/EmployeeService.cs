using NameSpace_Dll_Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace_Dll_Abstraction.Services
{
    internal class EmployeeService
    {
        public void FilterBySalary(decimal firstSalary, decimal secondSalary)
        {
            var employees = GetEmployees();

            foreach (Employee employee in employees)
            {
                if (employee.Salary > firstSalary && employee.Salary < secondSalary)
                {
                    string result = $"{employee.Id} , {employee.Name} , {employee.Surname} , {employee.Age} , {employee.Salary}";
                    Console.WriteLine(result);
                }
            }
        }


        private Employee[] GetEmployees()
        {
            Employee[] employees =
            {
                new Employee
                {
                    Id = 1,
                    Name = "Fidan",
                    Surname = "Beshirova",
                    Age = 22,
                    Salary = 1500

                },
                new Employee
                {Id = 2,
                    Name = "Pervin",
                    Surname = "Mirzeyev",
                    Age = 30,
                    Salary = 2400
                },
                new Employee
                {
                    Id = 3,
                    Name = "Sheref",
                    Surname = "Tenzilli",
                    Age = 26,
                    Salary = 1600
                },
                 new Employee
                {
                    Id = 4,
                    Name = "Cahangir",
                    Surname = "Axundov",
                    Age = 20,
                    Salary = 600
                },
            };

            return employees;
        }
    }
}
