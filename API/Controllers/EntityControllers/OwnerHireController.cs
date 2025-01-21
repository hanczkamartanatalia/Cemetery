using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class OwnerHireController : EntityController<OwnerHireService, OwnerHire>
    {
        [HttpPost("/owner-hire/create")]
        public new IActionResult Create([FromForm] OwnerHire ownerHire)
        {
            return base.Create(ownerHire);
        }

        [HttpPost("/owner-hire/edit")]
        public new IActionResult Edit([FromForm] OwnerHire ownerHire)
        {
            return base.Edit(ownerHire);
        }

        [HttpPost("/owner-hire/delete")]
        public new IActionResult Delete([FromForm] OwnerHire ownerHire)
        {
            return base.Delete(ownerHire);
        }

        [HttpPost("/owner-hire/list")]
        public new IActionResult List()
        {
            return base.List();
        }
    }
}