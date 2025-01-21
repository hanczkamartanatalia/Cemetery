using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class DeadController : EntityController<DeadService, Dead>
    {
        [HttpPost("/dead/create")]
        public new IActionResult Create([FromForm] Dead dead)
        {
            return base.Create(dead);
        }

        [HttpPost("/dead/edit")]
        public new IActionResult Edit([FromForm] Dead dead)
        {
            return base.Edit(dead);
        }

        [HttpPost("/dead/delete")]
        public new IActionResult Delete([FromForm] Dead dead)
        {
            return base.Delete(dead);
        }

        [HttpPost("/dead/list")]
        public new IActionResult List()
        {
            return base.List();
        }
    }
}
