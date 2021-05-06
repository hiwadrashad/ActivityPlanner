using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using ActivityPlannerBlazor.Shared.DTOS;
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
    public class OrganizerController : Controller
    {
        // GET: api/<OrganizerController>
        public IMockingRepo _repo = MockingRepo.GetMockingRepo();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllOrganizers());
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_repo.GetOrganizer(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] OrganizerDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdModel = _repo.AddOrganizerAndreturnModel(model);

            return Created("organizer", createdModel);
        }

        [HttpPut]
        public IActionResult Update([FromBody] OrganizerDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (model.FirstName == string.Empty || mdel.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = _repo.GetOrganizer(model.id);

            if (employeeToUpdate == null)
                return NotFound();

            _repo.UpdateOrganizer(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var ToDelete = _repo.GetOrganizer(id);
            if (ToDelete == null)
                return NotFound();

            _repo.DeleteOrganizer(id);

            return NoContent();//success
        }
    }
}
