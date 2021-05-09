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
    public class CurrentOrganizerController : Controller
    {
        public ICurrentUser _staticresources = StaticResources.CurrentStaticUser.GetCurrentStaticUser();
        // GET: api/<CurrentOrganizerController>
        [HttpGet]
        public IActionResult Get(string id)
        {
            return Ok(_staticresources.GetCurrentOrganizer()); ;
        }

        // GET api/<CurrentOrganizerController>/5
        [HttpGet("{id}")]
        public IActionResult GetCurrentUser(string id)
        {
            IEnumerable<OrganizerDTO> JSON = new List<OrganizerDTO>() { _staticresources.GetCurrentOrganizer()};            
            return Ok(JSON);
        }

        // POST api/<CurrentOrganizerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CurrentOrganizerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CurrentOrganizerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
