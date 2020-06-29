using Allen.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Allen.Services
{
    public class CustomerService
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

       


        public List<Customer> GetCustomers()
        {
            Customers.Add (new Customer(){ FirstName = "Customer 1", BirthDate = "12/02/1993", Id = 1, Email = "Customer1@yahoo.com" });
            Customers.Add (new Customer() {FirstName = "Customer 1", BirthDate = "12/02/1993", Id = 1, Email = "Customer2@yahoo.com" });
            Customers.Add (new Customer() {FirstName  = "Customer 1", BirthDate = "12/02/1993", Id = 1, Email = "Customer3@yahoo.com" });
            Customers.Add (new Customer() { FirstName = "Customer 1", BirthDate = "12/02/1993", Id = 1, Email = "Customer4@yahoo.com" });
            Customers.Add (new Customer() { FirstName = "Customer 1", BirthDate = "12/02/1993", Id = 1, Email = "Customer5@yahoo.com" });

            return Customers;
    }
    }
}
