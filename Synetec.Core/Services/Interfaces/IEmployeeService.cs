using Synetec.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synetec.Core.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeModel>> GetEmployeesAsync();
        public Task<BonusResponseModel> GetBonusByEmployeeAsync(BonusRequestModel model);
    }
}
