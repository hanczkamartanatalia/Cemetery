using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class OwnerController : BaseController<OwnerService, Owner>
    {

        [HttpPost("/owner/create")]
        public new IActionResult Create([FromForm] Owner owner)
        {
            return base.Create(owner);
        }

    }
}
