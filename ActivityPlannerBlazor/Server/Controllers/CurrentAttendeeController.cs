using ActivityPlannerBlazor.Repo.Interfaces;
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
    public class CurrentAttendeeController : Controller
    {
        public ICurrentUser _staticresources = StaticResources.CurrentStaticUser.GetCurrentStaticUser();
        // GET: api/<CurrentAttendeeController>
        [HttpGet]
        public IActionResult GetAttendee()
        {
            return Ok(_staticresources.GetCurrentAttendee());
        }

        // GET api/<CurrentAttendeeController>/5
        [HttpGet("{id}")]
        public IActionResult GetCurrentAttendee(string id)
        {
            IEnumerable<AttendeeDTO> JSON = new List<AttendeeDTO>() { _staticresources.GetCurrentAttendee() };
            return Ok(JSON);
        }

        // POST api/<CurrentAttendeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CurrentAttendeeController>/5
        [HttpPut]
        public IActionResult Update([FromBody] AttendeeDTO model)
        {
            if (model == null)
            return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var attendeeToUpdate = _staticresources.GetCurrentAttendee();

            if (attendeeToUpdate == null)
                return NotFound();

            _staticresources.UpdateCurrentAttendee(model);

            return NoContent();
        }

        // DELETE api/<CurrentAttendeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
