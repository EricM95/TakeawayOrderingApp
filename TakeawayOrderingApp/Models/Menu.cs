using System.ComponentModel.DataAnnotations;

namespace TakeawayOrderingApp.Models
{
    public class Menu
    {

        [Key]
        [Required]
        public int FoodId { get; set; }

        [Required]
        public string FoodItemName { get; set; }

        [Required]
        public IEnumerable<int> Ingredients { get; set; }

        [Required]
        [Range(1, 9999)]
        public float Price { get; set; } 

        [Required]
        public string Description { get; set; }
        

    }
}
