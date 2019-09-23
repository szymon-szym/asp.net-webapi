using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace roboAPIs.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReportCreateInProgressController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {

            return $"get";
        }

        // // GET api/values/5
        // [HttpGet("/test")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Item item)

        {
            var id = Guid.NewGuid().ToString();
            return $"received request for id {item.id}, name {item.name} test guid: {id}";

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Item 
    {
       public string id {get; set;}
        public string name {get; set;}

    }
}
