using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeawayOrderingApp.Models
{
    public class Order
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:C}")]
        [Display(Name ="Order Total")]
        public float TotalPrice { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required, Display (Name="Pick up Time")]
        public DateTime PickUpTime { get; set; }

        [Required, Display (Name ="Pick up Date")]
        public DateTime PickUpDate { get; set; }

        public string Comments  { get; set; }

        [Display (Name ="Pick up Name")]
        public string PickUpName { get; set; }

        [Display(Name ="Pick up Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
