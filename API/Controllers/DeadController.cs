using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class DeadController : BaseController<DeadService, Dead>
    {
        [HttpPost("/dead/create")]
        public new IActionResult Create([FromForm] Dead dead)
        {
            return base.Create(dead);
        }
    }
}
