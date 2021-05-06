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
    public class AttendeeController : Controller
    {
        public IMockingRepo _repo = MockingRepo.GetMockingRepo();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllAttendees());
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_repo.GetAttendee(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] AttendeeDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdModel = _repo.AddAttendeeAndReturnModel(model);

            return Created("attendee", createdModel);
        }

        [HttpPut]
        public IActionResult Update([FromBody] AttendeeDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (model.FirstName == string.Empty || mdel.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = _repo.GetAttendee(model.id);

            if (employeeToUpdate == null)
                return NotFound();

            _repo.UpdatAttendee(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var ToDelete = _repo.GetAttendee(id);
            if (ToDelete == null)
                return NotFound();

            _repo.DeleteAttendee(id);

            return NoContent();//success
        }
    }
}
