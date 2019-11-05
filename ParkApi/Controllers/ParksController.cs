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

        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string parkName, string location, string coordinates, string attraction, string information, string requirements)
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

            if (coordinates != null)
            {
                query = query.Where(entry => entry.Coordinates ==(coordinates));
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

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // GET api/parks/id
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // PUT api/parks/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/parks/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }

        // 
    }
}