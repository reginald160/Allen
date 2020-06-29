using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitesAcademyEFC.Models;
using CodeBitesAcademyEFC.User;
using Microsoft.AspNetCore.Mvc;

namespace CodeBitesAcademyEFC.Controllers
{
    public class UserController : Controller
    { private readonly Iuser _userContext;
        public UserController(Iuser _user) => _userContext = _user;
      
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account user)
        {
            //ViewBag.Message = "Invalid Input";
            _userContext.AddUser(user);

            return View();
        }

        public IActionResult Login (string username, string password)
        {

            ViewBag.Message = "Invalid Input";
            var pass = _userContext.Authentification(username, password);
            
            if (pass)
            {
                return View("Create");
            }
            return View(ViewBag);

           
        }



    }
}
