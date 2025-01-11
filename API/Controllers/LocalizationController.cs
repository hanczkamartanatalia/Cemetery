using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers
{
    public class LocalizationController : BaseController<LocalizationService, Localization>
    {
        [HttpPost("/localization/create")]
        public IActionResult Create([FromForm] Localization localization)
        {
            return base.Create(localization);
        }
    }
}
