using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TakeawayOrderingApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TakeawayOrderingAppUser class
public class TakeawayOrderingAppUser : IdentityUser
{

    [PersonalData]
    public string Name { get; set; }

    [PersonalData]
    [Required]
    public string Email { get; set; }

}

