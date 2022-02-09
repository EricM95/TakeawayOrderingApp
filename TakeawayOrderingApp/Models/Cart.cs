using System.ComponentModel.DataAnnotations;

namespace TakeawayOrderingApp.Models
{
    public class Cart
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FoodItemName { get; set; }

        [Required]
        public string FoodId { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
