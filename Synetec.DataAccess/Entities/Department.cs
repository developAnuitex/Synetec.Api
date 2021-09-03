using Synetec.DataAccess.Entities.Base;
using System.Collections.Generic;

namespace Synetec.DataAccess.Entities
{
    public class Department : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
