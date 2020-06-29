using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Models
{
    public class Outlets
    {
        [Key]
        public States Id { get; set; }
        public string Address { get; set; }
       
    }
}
