using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Services;

namespace API.Controllers.EntityControllers
{
    public class LocalizationController : EntityController<LocalizationService, Localization>
    {
        [HttpPost("/localization/create")]
        public new IActionResult Create([FromForm] Localization localization)
        {
            return base.Create(localization);
        }

        [HttpPost("/localization/edit")]
        public new IActionResult Edit([FromForm] Localization localization)
        {
            return base.Edit(localization);
        }

        [HttpPost("/localization/delete")]
        public new IActionResult Delete([FromForm] Localization localization)
        {
            return base.Delete(localization);
        }
    }
}
