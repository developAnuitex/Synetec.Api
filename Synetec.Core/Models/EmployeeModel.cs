using Synetec.Core.Models.Base;

namespace Synetec.Core.Models
{
    public class EmployeeModel : BaseModel
    {
        public string Fullname { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
