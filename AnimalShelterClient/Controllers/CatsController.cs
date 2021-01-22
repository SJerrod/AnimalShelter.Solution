using AnimalShelterClient.Models;
using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterClient.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            var allCats = Cat.GetCats();
            return View(allCats);
        }

        public IActionResult Details(int id)
        {
            var thisCat = Cat.GetDetails(id);
            return View(thisCat);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cat cat)
        {
            Cat.Post(cat);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisCat = Cat.GetDetails(id);
            return View(thisCat);
        }

        [HttpPost]
        public IActionResult Edit(Cat cat)
        {
            Cat.Put(cat);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Cat.Delete(id);
            return RedirectToAction("Index");
        }
    }
}