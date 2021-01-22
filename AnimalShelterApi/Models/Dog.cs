using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
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
    }
}