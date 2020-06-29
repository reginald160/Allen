using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Allen.Models
{
    public class AboutUscs
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNum { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }


    }
}
