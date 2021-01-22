using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private AnimalShelterApiContext _db;

        public CatsController(AnimalShelterApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cat>> Get(string catGender, int catAge, string catBreed)
        {
            var query = _db.Cats.AsQueryable();

            if (catGender != null)
            {
                query = query.Where(entry => entry.CatGender == catGender);
            }

            if (catAge != 0)
            {
                query = query.Where(entry => entry.CatAge == catAge);
            }

            if (catBreed != null)
            {
                query = query.Where(entry => entry.CatBreed == catBreed);
            }
            
            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Cat cat)
        {
            _db.Cats.Add(cat);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Cat> Get(int id)
        {
            return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cat cat)
        {
            cat.CatId = id;
            _db.Entry(cat).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
        _db.Cats.Remove(catToDelete);
        _db.SaveChanges();
        }
    }
}