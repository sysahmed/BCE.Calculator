using BCE.Business.Abstract;
using BCE.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BCE.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatesController : ControllerBase
    {
        IEmployeeService _employeeServices;
        public CalculatesController(IEmployeeService employeeServices)
        {
            _employeeServices = employeeServices;
        }
      
        [HttpPost]
        public IActionResult Calculate(Employees employee)
        {
            if (employee.GrossIncome > 1000)
            {
                var result = _employeeServices.Add(employee);
                if (result.Success)
                    return Ok(result.Data);
                return BadRequest(result.Message);
            }
            else
            {
                employee.NetIncome = employee.GrossIncome;
                return Ok(employee);
            }
        }
    }
}
