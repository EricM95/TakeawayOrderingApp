using System.ComponentModel.DataAnnotations;

namespace TakeawayOrderingApp.Models
{
    public class OrderDetails
    {

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public string FoodItemName { get; set; }

        [Required]
        public int FoodItemAmount { get; set; }

        [Required]
        public float OrderTotal { get; set; }
    }
}
