using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectTest.Controllers
{
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {
        //attributes
        private IRepository repository;

        // constructors
        public ReservationController(IRepository repo)
        {
            repository = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;
        // GET api/values/5
      
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Reservation result = repository[id];
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public Reservation Post([FromBody] Reservation res) =>
            repository.AddReservation(new Reservation
            {
                ClientName = res.ClientName,
                Location = res.Location,
            });

        // PUT api/values/5
        [HttpPut]
        public Reservation Put([FromBody] Reservation res) =>
             repository.UpdateReservation(res);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteReservation(id);
    }
}
