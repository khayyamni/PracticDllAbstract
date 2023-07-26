using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmployeeService
    {
        public Employee[] GetAll()
        {
            Employee[] employees =
            {
                new Employee
                {
                    Id = 1,
                    Name = "Ismayil",
                    Surname ="Efendizade",
                    Age = 29,
                    Salary =1200
                },

                 new Employee
                {
                    Id = 2,
                    Name = "Xeyyam",
                    Surname ="Isgenderov",
                    Age = 29,
                    Salary =1100
                },

                  new Employee
                {
                    Id = 3,
                    Name = "Cahangir",
                    Surname ="Axundov",
                    Age = 20,
                    Salary =1000
                },
            };

            return employees;

        }
    }
}
