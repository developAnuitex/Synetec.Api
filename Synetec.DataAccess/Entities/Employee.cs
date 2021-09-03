using Synetec.DataAccess.Entities.Base;

namespace Synetec.DataAccess.Entities
{
    public class Employee : BaseEntity
    {
        public string Fullname { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
