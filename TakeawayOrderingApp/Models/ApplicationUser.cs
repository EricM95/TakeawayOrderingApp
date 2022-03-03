using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TakeawayOrderingApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [Required]
        public override string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public override string PhoneNumber { get; set; }



    }
}
