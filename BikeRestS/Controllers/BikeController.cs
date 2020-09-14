using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bike;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeRestS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        //data
            private static List<Bikes> _data = new List<Bikes>()
            {
                new Bikes(1, "Yellow", 1000, 17,true),
                new Bikes(2, "Red", 1000, 21,true),
                new Bikes(3, "Purple", 1500, 7,false)
            };

            // GET: api/<BikeController>
            [HttpGet]
            public IEnumerable<Bikes> Get()
            {
                return _data;
            }

        // GET: api/<BikeController>
        [HttpGet]
        [Route("Search")]
        public IEnumerable<Bikes> Get([FromQuery] QueryBike query)
        {
            List<Bikes> tmpList = null;
            if (query.Color != null)
            {
                tmpList = _data.FindAll(b => b.Color.Contains(query.Color));
            }
            else
            {
                tmpList = _data;
            }
            return tmpList;
        }



        // GET api/<controller>/5
        [HttpGet("{id}")]
            public Bikes Get(int id)
            {
                return _data.Find(b => b.Id == id);
            }

            // POST api/<controller>
            [HttpPost]
            public void Post([FromBody] Bikes value)
            {
                _data.Add(value);
            }

            // PUT api/<controller>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] Bikes value)
            {
                Bikes bikes = Get(id);
                if (bikes != null)
                {
                    bikes.Id = value.Id;
                    bikes.Color = value.Color;
                    bikes.Price = value.Price;
                    bikes.Gear = value.Gear;
                    bikes.Mtb = value.Mtb;
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
