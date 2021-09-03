using System.ComponentModel.DataAnnotations;

namespace Synetec.Core.Models
{
    public class BonusRequestModel
    {
        [Required]
        [RegularExpression(@"^(0*[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*)$", ErrorMessage = "the value must be greater than 0")]
        public decimal BonusAmount { get; set; }

        [Required]
        [RegularExpression(@"^[1-9][0-9]*$", ErrorMessage = "the value must be greater than 0")]
        public long EmployeeId { get; set; }
    }
}
