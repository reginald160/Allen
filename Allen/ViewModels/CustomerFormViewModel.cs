using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allen.Models;

namespace Allen.ViewModels
{
    public class CustomerFormViewModel
    {

        /* public IEnumerable<MembershipType> MembershipTypes { get; set; }*/

        public List<Customer> Customer { get; set; } = new List<Customer>();
    }
}
