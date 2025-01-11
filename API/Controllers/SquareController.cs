using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class SquareController : BaseController<SquareService, Square>
    {
        [HttpPost("/square/create")]
        public new IActionResult Create([FromForm] Square square)
        {
            return base.Create(square);
        }
    }
}
