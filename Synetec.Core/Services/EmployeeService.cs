using AutoMapper;
using Synetec.Core.Models;
using Synetec.Core.Services.Interfaces;
using Synetec.DataAccess.Repositories.Interfaces;
using Synetec.Shared.Common;
using Synetec.Shared.Constants;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Synetec.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployeesAsync()
        {
            var result = await _employeeRepository.GetAllAsync();
            var mappedResult = _mapper.Map<IEnumerable<EmployeeModel>>(result);
            return mappedResult;

        }
        public async Task<BonusResponseModel> GetBonusByEmployeeAsync(BonusRequestModel model)
        {
            var employee = await _employeeRepository.GetByIdAsync(model.EmployeeId);
            if (employee is null)
            {
                throw new AppException(AppConstant.Errors.NOT_FOUND, HttpStatusCode.BadRequest);
            }
            var mappedEmployee = _mapper.Map<EmployeeModel>(employee);

            decimal totalSalary = await _employeeRepository.GetTotalSalaryAsync();
            decimal shareInSalary = employee.Salary / totalSalary;
            decimal individualBonus = model.BonusAmount * shareInSalary;

            return new BonusResponseModel
            {
                Employee = mappedEmployee,
                IndividualBonusAmount = individualBonus,
                TotalBonusAmount = model.BonusAmount,
                TotalSalary = totalSalary
            };
        }
    }
}
