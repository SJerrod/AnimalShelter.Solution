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
    }
}