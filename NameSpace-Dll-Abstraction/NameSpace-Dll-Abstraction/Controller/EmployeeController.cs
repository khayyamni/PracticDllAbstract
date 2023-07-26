using NameSpace_Dll_Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace NameSpace_Dll_Abstraction.Controller
//{
//    internal class EmployeeController
//    {
//        private EmployeeService _employeeService;

//        public EmployeeController()
//        {
//            _employeeService = new EmployeeService();
//        }

//        public void FilterBySalary()
//        {
//            decimal firstSalary = 2000;
//            decimal secondSalary = 3000;
//            _employeeService.FilterBySalary(firstSalary, secondSalary);
//        }
//    }
//}


namespace NameSpace_Dll_Abstraction.Controller
{
    public class EmployeeController
    {
        private EmployeeService _employeeService; 

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }   
        public void GetAllEmployees()
        {
            var employes = _employeeService.GetAll
        }

    }
}