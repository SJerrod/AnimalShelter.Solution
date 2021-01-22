using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private AnimalShelterApiContext _db;

        public DogsController(AnimalShelterApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get(string dogGender, int dogAge, string dogBreed)
        {
            var query = _db.Dogs.AsQueryable();

            if (dogGender != null)
            {
                query = query.Where(entry => entry.DogGender == dogGender);
            }

            if (dogAge != 0)
            {
                query = query.Where(entry => entry.DogAge == dogAge);
            }

            if (dogBreed != null)
            {
                query = query.Where(entry => entry.DogBreed == dogBreed);
            }
            
            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Dog dog)
        {
            _db.Dogs.Add(dog);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Dog> Get(int id)
        {
            return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dog dog)
        {
            dog.DogId = id;
            _db.Entry(dog).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
            _db.Dogs.Remove(dogToDelete);
            _db.SaveChanges();
        }
    }
}