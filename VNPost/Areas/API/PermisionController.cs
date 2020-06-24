using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.Models.Entity;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    public class PermisionController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Object> data)
        {
            //string x = data[0];
            //var list = data[0].GetType().GetProperties();
            if (true)
            {

            }
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }

   public class DataFromClient
    {
        public DataFromClient()
        {
        }

        public DataFromClient(int id, List<CURDFromClient> cURDs)
        {
            Id = id;
            CURDs = cURDs;
        }

        public int Id { get; set; }
        public List<CURDFromClient> CURDs { get; set; }
    }

   public class CURDFromClient
    {
        public CURDFromClient()
        {
        }

        public CURDFromClient(int id, bool state)
        {
            Id = id;
            State = state;
        }

        public int Id { get; set; }
        public bool State { get; set; }
    }
}
