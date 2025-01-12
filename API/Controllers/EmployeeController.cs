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

        [HttpPost("/employee/edit")]
        public new IActionResult Edit([FromForm] Employee employee)
        {
            return base.Edit(employee);
        }

        [HttpPost("/employee/delete")]
        public new IActionResult Delete([FromForm] Employee employee)
        {
            return base.Delete(employee);
        }
    }
}
