using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitesAcademyEFC.Service;
using Microsoft.AspNetCore.Mvc;
using CodeBitesAcademyEFC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.CodeAnalysis.Differencing;

namespace CodeBitesAcademyEFC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee) => _employee = employee;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_employee.Employee);
        }

        [HttpGet]
        public IActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                _employee.AddEmployee(employee);
                return View("Details", employee);
            }
            return View();
        }

       
       

        [HttpGet]
        public IActionResult Delete (int Id)
        { EmployeeModel employee = _employee.GetEmployee(Id);
            if( employee == null )
            {
                return RedirectToAction("List");
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int Id)
        {
            var employee = _employee.Delete(Id);
            return View("DeletedPage", employee); 
        }
                                                                                                                                                                                                                                                                                                                                   
        public IActionResult Details(int Id)
        {
            EmployeeModel employee = _employee.GetEmployee(Id);

            return View(employee);
        }


        [HttpGet]
        public IActionResult Edit(int Id )
        {
            EmployeeModel employee = _employee.GetEmployee(Id);
            return View(employee);
        }

        [HttpPost]
         public IActionResult Edit(EmployeeModel employee)
        {
            _employee.Edit(employee);

            return RedirectToAction("List", "Employee");
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Search (string surname)
        {
             
            IQueryable<EmployeeModel> emp = _employee.Search(surname);
            return View("SearchResult", emp);
        }


        public IActionResult SearchResult()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Department()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Department(Department user)
        {
            //ViewBag.Message = "Invalid Input";
           _employee.AddDepartment(user);

            return View();
        }

    }
}
