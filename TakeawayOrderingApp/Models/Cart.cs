using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeawayOrderingApp.Models
{
    public class Cart
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("FoodId")]
        public int FoodId { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string FoodItemName { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
