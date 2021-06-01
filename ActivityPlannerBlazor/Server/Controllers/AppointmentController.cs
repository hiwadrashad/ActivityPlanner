using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivityPlannerBlazor.Shared.DTOS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActivityPlannerBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        
        public IMockingRepo _repo = MockingRepo.GetMockingRepo();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllAppointments());
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_repo.GetAppointment(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] AppointmentDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdModel = _repo.AddAppointmentAndReturnModel(model);

            return Created("appointment", createdModel);
        }

        [HttpPut]
        public IActionResult Update([FromBody] AppointmentDTO model)
        {
            if (model == null)
                return BadRequest();

            //if (model.FirstName == string.Empty || mdel.LastName == string.Empty)
            //{
            //    ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = _repo.GetAppointment(model.id);

            if (employeeToUpdate == null)
                return NotFound();

            _repo.UpdateAppointment(model);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null)
                return BadRequest();

            var ToDelete = _repo.GetAppointment(id);
            if (ToDelete == null)
                return NotFound();

            _repo.DeleteAppointment(id);

            return NoContent();//success
        }
    }
}
