using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class OwnerController : EntityController<OwnerService, Owner>
    {

        [HttpPost("/owner/create")]
        public new IActionResult Create([FromForm] Owner owner)
        {
            return base.Create(owner);
        }

        [HttpPost("/owner/edit")]
        public new IActionResult Edit([FromForm] Owner owner)
        {
            return base.Edit(owner);
        }

        [HttpPost("/owner/delete")]
        public new IActionResult Delete([FromForm] Owner owner)
        {
            return base.Delete(owner);
        }


        [HttpPost("/owner/list")]
        public new IActionResult List()
        {
            return base.List();
        }

    }
}
