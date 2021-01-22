using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
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
    }
}