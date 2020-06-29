using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitesAcademyEFC.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(12)")]
        public string FirstName { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(12)")]
        public string LastName { get; set; }

    }
}
