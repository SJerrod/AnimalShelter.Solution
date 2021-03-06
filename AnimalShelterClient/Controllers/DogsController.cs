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
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            var allDogs = Dog.GetDogs();
            return View(allDogs);
        }

        public IActionResult Details(int id)
        {
            var thisDog = Dog.GetDetails(id);
            return View(thisDog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dog dog)
        {
            Dog.Post(dog);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisDog = Dog.GetDetails(id);
            return View(thisDog);
        }

        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            Dog.Put(dog);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Dog.Delete(id);
            return RedirectToAction("Index");
        }
    }
}