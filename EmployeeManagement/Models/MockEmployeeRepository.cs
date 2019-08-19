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
                new Employee(){Id = 1, Name="Bhavin", Email="bhavin@solvis.technology",Department="IT" },
                new Employee(){Id = 2, Name="Brijesh", Email="bhavin@solvis.technology",Department="IT" },
                new Employee(){Id = 3, Name="Rajesh", Email="bhavin@solvis.technology",Department="HR" },
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
