using EntitiesLib.Entities;
using Microsoft.AspNetCore.Mvc;
using ServicesLib.Interfaces;
using ServicesLib.Services;

namespace API.Controllers
{
    public abstract class BaseController<T, G> : Controller
        where T : Service<T, G>, IValidate<G>, new()
        where G : Entity
    {
        public IActionResult Create([FromForm] G entity)
        {
            G? created = Service<T, G>.Instance().Create(entity);
            if (created == null)
            {
                return BadRequest("Incorrect data");
            }
            return Ok(created);
        }

        public IActionResult Edit([FromForm] G entity)
        {
            G? edited = Service<T, G>.Instance().Edit(entity);
            if (edited == null)
            {
                return BadRequest("Incorrect data");
            }
            return Ok(edited);
        }

        public IActionResult Delete([FromForm] G entity)
        {
            G? deleted = Service<T, G>.Instance().Delete(entity);
            if (deleted == null)
            {
                return BadRequest("Entity is deleted");
            }
            return Ok(deleted);
        }
    }
}
