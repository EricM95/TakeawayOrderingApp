using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeawayOrderingApp.Models
{

    public class MenuItem
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public ICollection<string> Ingredients { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater than £1")]
        public double Price { get; set; }

        [Display(Name ="Category")]
        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set;}




    }
}
