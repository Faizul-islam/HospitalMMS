using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalMMS.Data;
using HospitalMMS.Modules.AllCommonModelClass.Models;

namespace HospitalMMS.Modules.EmployeeModule
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Employee Add(Employee employee)
        {
            context.Employee.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employee.Find(id);
            if(employee != null)
            {
                context.Employee.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employee;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employee.Find(id);
        }

        public Employee Uodate(Employee employeeChanges)
        {
            var employee = context.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
