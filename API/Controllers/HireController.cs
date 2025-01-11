using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class HireController : BaseController<HireService, Hire>
    {
        [HttpPost("/hire/create")]
        public new IActionResult Create([FromForm] Hire hire)
        {
            return base.Create(hire);
        }
    }
}
