using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class DeadSquareController : EntityController<DeadSquareService, DeadSquare>
    {
        [HttpPost("/dead-square/create")]
        public new IActionResult Create([FromForm] DeadSquare deadSquare)
        {
            return base.Create(deadSquare);
        }

        [HttpPost("/dead-square/edit")]
        public new IActionResult Edit([FromForm] DeadSquare deadSquare)
        {
            return base.Edit(deadSquare);
        }

        [HttpPost("/dead-square/delete")]
        public new IActionResult Delete([FromForm] DeadSquare deadSquare)
        {
            return base.Delete(deadSquare);
        }

        [HttpPost("/dead-square/list")]
        public new IActionResult List()
        {
            return base.List();
        }
    }
}
