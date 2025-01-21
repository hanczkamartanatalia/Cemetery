using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class FuneralController : EntityController<FuneralService, Funeral>
    {
        [HttpPost("/funeral/create")]
        public new IActionResult Create([FromForm] Funeral funeral)
        {
            return base.Create(funeral);
        }

        [HttpPost("/funeral/edit")]
        public new IActionResult Edit([FromForm] Funeral funeral)
        {
            return base.Edit(funeral);
        }

        [HttpPost("/funeral/delete")]
        public new IActionResult Delete([FromForm] Funeral funeral)
        {
            return base.Delete(funeral);
        }

        [HttpPost("/funeral/list")]
        public new IActionResult List()
        {
            return base.List();
        }
    }
}
