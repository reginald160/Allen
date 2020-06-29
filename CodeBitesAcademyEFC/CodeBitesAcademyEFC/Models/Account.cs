using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitesAcademyEFC.Models
{
    public class Account
    {[Key]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Status { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Role { get; set; }


        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]

        [Required]
        [Column(TypeName = "varchar(10)")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}


