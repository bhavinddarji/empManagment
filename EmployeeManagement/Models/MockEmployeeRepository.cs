using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;
        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee(){Id = 1, Name="Bhavin", Email="bhavin@solvis.technology",Department=Dept.HR },
                new Employee(){Id = 2, Name="Brijesh", Email="bhavin@solvis.technology",Department=Dept.IT },
                new Employee(){Id = 3, Name="Rajesh", Email="bhavin@solvis.technology",Department=Dept.MR },
            };
        }

        public Employee Add(Employee employee)
        {
            _employeesList.Add(employee);
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                _employeesList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(x => x.Id == Id);
        }

        public Employee Update(Employee employee)
        {
            Employee emp = _employeesList.FirstOrDefault(e => e.Id == employee.Id);
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Department = employee.Department;
            }
            return employee;
        }
    }
}
