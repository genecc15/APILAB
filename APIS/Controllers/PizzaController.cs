using APIS.Models;
using APIS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaService _PizzaService;

        public PizzasController(PizzaService PizzaService)
        {
            _PizzaService = PizzaService;
        }

        //http://localhost:<port>/api/Pizzas
        [HttpGet]
        public ActionResult<List<Pizza>> Get() =>
            _PizzaService.Get();

        //http://localhost:<port>/api/Pizzas/id 
        [HttpGet("{id:length(24)}", Name = "GetPizza")]
        public ActionResult<Pizza> Get(string id)
        {
            var Pizza = _PizzaService.Get(id);

            if (Pizza == null)
            {
                return NotFound();
            }

            return Pizza;
        }

        //Adjuntar JSON
        [HttpPost]
        public ActionResult<Pizza> Create(Pizza Pizza)
        {
            _PizzaService.Create(Pizza);

            return CreatedAtRoute("GetPizza", new { id = Pizza.Id.ToString() }, Pizza);
        }

        //http://localhost:<port>/api/Pizzas/id
        //Adjuntar JSON
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Pizza PizzaIn)
        {
            var Pizza = _PizzaService.Get(id);

            if (Pizza == null)
            {
                return NotFound();
            }

            _PizzaService.Update(id, PizzaIn);

            return Ok();
        }

        //http://localhost:<port>/api/Pizzas/id
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var Pizza = _PizzaService.Get(id);

            if (Pizza == null)
            {
                return NotFound();
            }

            _PizzaService.Remove(Pizza.Id);

            return NoContent();
        }
    }
}