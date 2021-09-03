using Synetec.DataAccess.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synetec.DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public Task CreateAsync(TEntity model);
        public Task UpdateAsync(TEntity model);
        public Task DeleteAsync(TEntity model);
        public Task<TEntity> GetByIdAsync(long id);
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task SaveChagesAsync();
    }
}
