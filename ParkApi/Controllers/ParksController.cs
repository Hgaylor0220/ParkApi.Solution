using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace ParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParkApiDbContext _db;

        public ParksController(ParkApiDbContext db)
        {
            _db = db;
        }

        // GET api/rivers
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string parkName, string location, int corrdinates, string attraction, string information, string requirements)
        {
            var query = _db.Parks.AsQueryable();

            if (parkName != null)
            {
                query = query.Where(entry => entry.ParkName.Contains(parkName));
            }

            if (location != null)
            {
                query = query.Where(entry => entry.Location.Contains(location));
            }

            if (corrdinates != null)
            {
                query = query.Where(entry => entry.Corrdinates ==(corrdinates));
            }

            if (attraction != null)
            {
                query = query.Where(entry => entry.Attraction.Contains(attraction));
            }

            if (information != null)
            {
                query = query.Where(entry => entry.Information.Contains(information));
            }

            if (requirements != null)
            {
                query = query.Where(entry => entry.RequirmentType.Contains(requirements));
            }



            return query.ToList();
        }

        // POST api/rivers
        [HttpPost]
        public void Post([FromBody] Park river)
        {
            _db.Parks.Add(river);
            _db.SaveChanges();
        }

        // GET api/rivers/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // PUT api/rivers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park river)
        {
            river.ParkId = id;
            _db.Entry(river).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/rivers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var riverToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(riverToDelete);
            _db.SaveChanges();
        }
    }
}