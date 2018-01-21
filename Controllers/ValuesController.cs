using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lca_api.Controllers
{
    [Route("api/lca")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("{location}")]
        public IActionResult Get(string location)
        {
            switch (location.ToLower())
            {
                case "bne":
                case "brisbane":
                    return Ok(new{
                        Location = "UQ St Lucia and QUT Kelvin Grove",
                        Years = new[] {"2002", "2011"},
                        IsBestCity = true
                    });
                case "syd":
                case "sydney":
                    return Ok(new {
                        Location = "UTS Sydney",
                        Years = new[] {"2001", "2007", "2018"},
                        IsBestCity = false
                    });
                default:
                    return NotFound();
            }
        }
    }
}
