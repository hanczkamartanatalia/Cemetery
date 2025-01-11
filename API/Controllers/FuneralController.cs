using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class FuneralController : BaseController<FuneralService, Funeral>
    {
        [HttpPost("/funeral/create")]
        public new IActionResult Create([FromForm] Funeral funeral)
        {
            return base.Create(funeral);
        }
    }
}
