using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class EmployeeController : BaseController<EmployeeService,Employee>
    {
        [HttpPost("/employee/create")]
        public new IActionResult Create([FromForm] Employee employee)
        {
          return base.Create(employee);
        }
    }
}
