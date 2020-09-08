using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bike;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeRest
{
    [Route("api/[controller]")]
    public class BikeController : Controller
    {
        //data
        private static List<Bikes> _data = new List<Bikes>()
        {
            new Bikes(1, "Yellow", 1000, 17),
            new Bikes(2, "Red", 1000, 21),
            new Bikes(3, "Purple", 1500, 7)
        };

        // GET: api/<BikeController>
        [HttpGet]
        public IEnumerable<Bikes> Get()
        {
            return _data;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Bikes Get(int id)
        {
            return _data.Find(p => p.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Bikes value)
        {
            Bikes bikes = Get(id);
            if (bikes != null)
            {
                bikes.Id = value.Id;
                bikes.Color = value.Color;
                bikes.Price = value.Price;
                bikes.Gear = value.Gear;
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Bikes bikes = Get(id);
            if (bikes != null)
            {
                _data.Remove(bikes);
            }
        }
    }
}
