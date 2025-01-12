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

        [HttpPost("/hire/edit")]
        public new IActionResult Edit([FromForm] Hire hire)
        {
            return base.Edit(hire);
        }

        [HttpPost("/hire/delete")]
        public new IActionResult Delete([FromForm] Hire hire)
        {
            return base.Delete(hire);
        }
    }
}
