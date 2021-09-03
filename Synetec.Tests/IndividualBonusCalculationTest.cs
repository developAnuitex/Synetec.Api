using Synetec.DataAccess.Entities;
using System;
using Xunit;

namespace Synetec.Tests
{
    public class IndividualBonusCalculationTest
    {
        [Fact]
        public void CalculationTest()
        {
            //Arrange
            Employee employee = new Employee { Id = 1, Fullname = "John Smith", JobTitle = "Accountant (Senior)", Salary = 97, DepartmentId = 1 };
            decimal totalSalary = 1000;
            decimal bonusAmount = 150;

            //Act
            decimal shareInSalary = employee.Salary / totalSalary;
            decimal individualBonus = Math.Round(bonusAmount * shareInSalary, 2);

            //Assert
            Assert.Equal(14.55m, individualBonus);
        }
    }
}
