using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        [Required]
        [StringLength(25)]
        public string DogName { get; set; }
        [Required]
        [StringLength(6)]
        public string DogGender { get; set; }
        [Required]
        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
        public int DogAge { get; set; }
        [Required]
        public string DogBreed { get; set; }
        [Required]
        public string DogTemperment { get; set; }

        public static List<Dog> GetDogs()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Dog> dogList = JsonConvert.DeserializeObject<List<Dog>>(jsonResponse.ToString());

            return dogList;
        }

        public static Dog GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Dog dog = JsonConvert.DeserializeObject<Dog>(jsonResponse.ToString());

            return dog;
        }

        public static void Post(Dog dog)
        {
            string jsonDog = JsonConvert.SerializeObject(dog);
            var apiCallTask = ApiHelper.Post(jsonDog);
        }

        public static void Put(Dog dog)
        {
            string jsonDog = JsonConvert.SerializeObject(dog);
            var apiCallTask = ApiHelper.Put(dog.DogId, jsonDog);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}