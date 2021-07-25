using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program_api.Controllers
{
    [Route("api/crud")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        List<string> Companies = new List<string>
        {
            "Apple",
            "Amazon",
            "Blackberry",
            "Facebook",
            "Instagram"
        };
        [HttpGet]
        [Route("GetCompanies")]
        public IActionResult GetAllCompanies()
        {
            var result = Companies.Where(W => W.Contains("y")).ToArray();
            return Ok(result);
        }

        [HttpGet("{letter}")]
        [Route ("DataFromUser")]
        public IActionResult FromUser([FromQuery] string letter)
        {

            try
            {

                var result = Companies.Where(W => W.Contains(letter)).ToArray();
                if (result.Length > 0)
                {

                    return Ok(result);
                }
                return NotFound("Data not found");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
    }
}
