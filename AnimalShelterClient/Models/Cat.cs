using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        [Required]
        [StringLength(25)]
        public string CatName { get; set; }
        [Required]
        [StringLength(6)]
        public string CatGender { get; set; }
        [Required]
        [Range(0, 40, ErrorMessage = "Age must be between 0 and 40.")]
        public int CatAge { get; set; }
        [Required]
        public string CatBreed { get; set; }
        [Required]
        public string CatTemperment { get; set; }

        public static List<Cat> GetCats()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(jsonResponse.ToString());

            return catList;
        }

        public static Cat GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Cat cat = JsonConvert.DeserializeObject<Cat>(jsonResponse.ToString());

            return cat;
        }

        public static void Post(Cat cat)
        {
            string jsonCat = JsonConvert.SerializeObject(cat);
            var apiCallTask = ApiHelper.Post(jsonCat);
        }

        public static void Put(Cat cat)
        {
            string jsonCat = JsonConvert.SerializeObject(cat);
            var apiCallTask = ApiHelper.Put(cat.CatId, jsonCat);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}