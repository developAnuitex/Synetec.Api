using Microsoft.EntityFrameworkCore;
using Synetec.DataAccess.Entities;
using Synetec.DataAccess.Repositories.Base;
using Synetec.DataAccess.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Synetec.DataAccess.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<decimal> GetTotalSalaryAsync()
        {
            var result = await _dbSet.SumAsync(x => x.Salary);
            return result;
        }
    }
}
