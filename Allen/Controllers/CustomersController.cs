using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Allen.Models;
using Allen.ViewModels;
using Allen.Services;
using System.Security.Cryptography.X509Certificates;

namespace Allen.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerService customerService;


        public CustomersController(CustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult CustomerForm()
       {

            

           var  customers = customerService.GetCustomers();
            
            return View(customers);
        
            
        }
            
             
     
        


    }
    
}
