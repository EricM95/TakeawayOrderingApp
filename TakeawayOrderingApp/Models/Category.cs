using System.ComponentModel.DataAnnotations;

namespace TakeawayOrderingApp.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        [Display(Name ="Category Name")]
        public string Name { get; set; }

        [Required,Display(Name ="Display Order")]
        public int DisplayOrder { get; set; }

    }
}
