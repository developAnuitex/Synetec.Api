using Microsoft.EntityFrameworkCore;
using Synetec.DataAccess.Entities;

namespace Synetec.DataAccess.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
               .HasData(
               new Department[]
               {
                   new Department{Id = 1, Title =  "Finance", Description= "The finance department for the company"},
                   new Department{Id = 2,Title = "Human Resources", Description = "The Human Resources department for the company"},
                   new Department{Id = 3, Title = "IT",Description = "The IT support department for the company"},
                   new Department{Id = 4, Title = "Marketing",Description = "The Marketing department for the company"}

               });


            modelBuilder.Entity<Employee>()
               .HasData(
               new Employee[]
               {
                    new Employee{Id = 1, Fullname = "John Smith", JobTitle = "Accountant (Senior)", Salary = 50000, DepartmentId = 1},
                    new Employee{Id = 2, Fullname = "Janet Jones", JobTitle = "HR Director", Salary = 90000, DepartmentId = 2},
                    new Employee{Id = 3, Fullname = "Robert Rinser", JobTitle = "IT Director", Salary = 95000, DepartmentId = 3},
                    new Employee{Id = 4, Fullname = "Jilly Thornton", JobTitle = "Marketing Manager (Senior)", Salary = 55000, DepartmentId = 4},
                    new Employee{Id = 5, Fullname = "Gemma Jones", JobTitle = "Marketing Manager (Junior)", Salary = 45000, DepartmentId =  4},
                    new Employee{Id = 6, Fullname = "Peter Bateman", JobTitle = "IT Support Engineer", Salary = 35000, DepartmentId = 3},
                    new Employee{Id = 7, Fullname = "Azimir Smirkov", JobTitle = "Creative Director", Salary = 62500, DepartmentId = 4},
                    new Employee{Id = 8, Fullname = "Penelope Scunthorpe", JobTitle = "Creative Assistant", Salary = 38750, DepartmentId = 4},
                    new Employee{Id = 9, Fullname = "Amil Kahn", JobTitle = "IT Support Engineer", Salary = 36000, DepartmentId = 3},
                    new Employee{Id = 10, Fullname = "Joe Masters", JobTitle = "IT Support Engineer", Salary = 36500, DepartmentId = 3},
                    new Employee{Id = 11, Fullname = "Paul Azgul", JobTitle = "HR Manager", Salary = 53000, DepartmentId = 2},
                    new Employee{Id = 12, Fullname = "Jennifer Smith", JobTitle = "Accountant (Junior)", Salary = 50000, DepartmentId = 1 },
               });
        }
    }
}
