using Microsoft.AspNetCore.Mvc;
using Synetec.Core.Models;
using Synetec.Core.Services.Interfaces;
using System.Threading.Tasks;

namespace Synetec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get-employee")]
        public async Task<IActionResult> GetEmployee()
        {
            var result = await _employeeService.GetEmployeesAsync();
            return Ok(result);
        }

        [HttpPost("get-bonus")]
        public async Task<IActionResult> GetIndividualBonus([FromBody] BonusRequestModel model)
        {
            var result = await _employeeService.GetBonusByEmployeeAsync(model);
            return Ok(result);
        }
    }
}
