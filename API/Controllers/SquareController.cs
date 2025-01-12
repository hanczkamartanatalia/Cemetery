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

        [HttpPost("/square/edit")]
        public new IActionResult Edit([FromForm] Square square)
        {
            return base.Edit(square);
        }

        [HttpPost("/square/delete")]
        public new IActionResult Delete([FromForm] Square square)
        {
            return base.Delete(square);
        }
    }
}
