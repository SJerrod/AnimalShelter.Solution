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

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
        return _db.Dogs.ToList();
    }

    // POST api/Dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
        _db.Dogs.Add(dog);
        _db.SaveChanges();
    }

    // GET api/animals/5
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

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}