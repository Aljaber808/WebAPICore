using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace platformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all The customers");
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
           
            return Ok($"Reading customer {name}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a customers");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("updating a customers");
        }

        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            return Ok($"Deleting a customer {name}.");
        }
    }
}
