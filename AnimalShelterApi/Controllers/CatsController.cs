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

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
        return _db.Cats.ToList();
    }

    // POST api/Cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
        _db.Cats.Add(cat);
        _db.SaveChanges();
    }

    // GET api/animals/5
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

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}