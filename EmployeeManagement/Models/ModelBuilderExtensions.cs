using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBinder)
        {
            modelBinder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 1,
                  Name = "Vipul",
                  Department = Dept.IT,
                  Email = "Vipul@test.com"
              },
              new Employee
              {
                  Id = 2,
                  Name = "Bharat",
                  Department = Dept.HR,
                  Email = "Bharat@test.com"
              }
            );
        }
    }
}
