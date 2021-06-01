using ActivityPlannerBlazor.Server.Repos;
using ActivityPlannerBlazor.Shared.DTOS;
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
    public class RolesController : Controller
    {
        // GET: api/<RolesController>
        [HttpGet]
        public IActionResult GetAll ()
        {
            RoleDTO role = new RoleDTO();
            role.Organizer = "organizer";
            //if (User.IsInRole("organizer"))
            //{
            //    role.Organizer = "organizer";
            //    role.Attendee = null;
            //    role.None = null;
            //}
            //if (User.IsInRole("attendee"))
            //{
            //    role.Organizer = null;
            //    role.Attendee = "attendee";
            //    role.None = null;
            //}
            //else
            //{
            //    role.Organizer = null;
            //    role.Attendee = null;
            //    role.None = "none";
            //}
            return Ok(role);
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
