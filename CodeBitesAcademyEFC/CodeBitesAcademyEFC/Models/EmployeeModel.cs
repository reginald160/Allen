using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CodeBitesAcademyEFC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [Display( Name = "First Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string LasttName { get; set; }
        
        [Required]
        public Department Department { get; set; }

        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Home Address")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
      
        [StringLength(11, MinimumLength =11)]
        public string Number { get; set; }

        [NotMapped]
        [DisplayName("Upload image")]
        public IFormFile Photo { get; set; }
    }
}
