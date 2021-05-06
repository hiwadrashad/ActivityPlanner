using ActivityPlannerBlazor.Server.Repos;
using ActivityPlannerBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActivityPlannerBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitialController : Controller
    {
        public InitialRepo _repo = InitialRepo.GetInitialRepo();
        // GET: api/<InitialController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.ReturnAllInitialModels());
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_repo.ReturnInitialModel(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] InitialModel model)
        {
            if (model == null)
                return BadRequest();

            //if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdModel = _repo.AddInitalAndReturnModel(model);

            return Created("intial", createdModel);
        }

        [HttpPut]
        public IActionResult Update([FromBody] InitialModel model)
        {
            if (model == null)
                return BadRequest();

            //if (model.FirstName == string.Empty || mdel.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = _repo.ReturnInitialModel(model.id);

            if (employeeToUpdate == null)
                return NotFound();

            _repo.UpdateInitialModel(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var ToDelete = _repo.ReturnInitialModel(id);
            if (ToDelete == null)
                return NotFound();

            _repo.RemoveInitial(id);

            return NoContent();//success
        }
    }
}
