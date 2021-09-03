namespace Synetec.Core.Models
{
    public class BonusResponseModel
    {
        public decimal TotalBonusAmount { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal IndividualBonusAmount { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
