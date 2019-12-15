using HospitalMMS.Modules.AllCommonModelClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.EmployeeModule
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Uodate(Employee employeeChanges);
        Employee Delete(int id);
        //EmployeeViewModel GetEmployee(int id);
        //IEnumerable<EmployeeViewModel> GetAllEmployees();
        //EmployeeViewModel Add(EmployeeViewModel employee);
        //EmployeeViewModel Uodate(EmployeeViewModel employeeChanges);
        //EmployeeViewModel Delete(int id);
    }
}
