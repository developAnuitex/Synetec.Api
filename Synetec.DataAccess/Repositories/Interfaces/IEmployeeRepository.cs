using Synetec.DataAccess.Entities;
using System.Threading.Tasks;

namespace Synetec.DataAccess.Repositories.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        public Task<decimal> GetTotalSalaryAsync();
    }
}
