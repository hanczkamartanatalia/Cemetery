using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class FuneralEmployeeController : EntityController<FuneralEmployeeService, FuneralEmployee>
    {

        [HttpPost("/funeral-employee/create")]
        public new IActionResult Create([FromForm] FuneralEmployee funeralEmployee)
        {
            return base.Create(funeralEmployee);
        }

        [HttpPost("/funeral-employee/edit")]
        public new IActionResult Edit([FromForm] FuneralEmployee funeralEmployee)
        {
            return base.Edit(funeralEmployee);
        }

        [HttpPost("/funeral-employee/delete")]
        public new IActionResult Delete([FromForm] FuneralEmployee funeralEmployee)
        {
            return base.Delete(funeralEmployee);
        }

        [HttpPost("/funeral-employee/list")]
        public new IActionResult List()
        {
            return base.List();
        }
    }
}
