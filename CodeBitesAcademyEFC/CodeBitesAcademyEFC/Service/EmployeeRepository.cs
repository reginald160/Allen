using CodeBitesAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CodeBitesAcademyEFC.Service
{
    public class EmployeeRepository : IEmployee
    {
        private readonly DataContext _context ;
        private readonly IWebHostEnvironment _environment;
       

        /*   public EmployeeRepository(DataContext context) =>  _context = context*/
        public EmployeeRepository(DataContext context, IWebHostEnvironment environment)
        {
           _environment = environment;
            _context = context;
        }
        /* public IEnumerable<EmployeeModel> Employee => return _context.EmployeeTable; the Table in the datacontext has been exposed*/

        public IEnumerable<EmployeeModel> Employee
        {
            get
            {
                return _context.EmployeeTaabl;
            }
          
        }

      
    public  void AddEmployee (EmployeeModel employee)
        {
            string Name = null;
            //    string Name = null;
            //    string wwwroothPath = _environment.WebRootPath;
            //    string fileName = Path.GetFileNameWithoutExtension(employee.Photo.FileName);
            //    string extention = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
            //     Name = DateTime.Now.ToString("dd/mm/yy/ss:fff") + extention;
            //    string ImgPath = Path.Combine(wwwroothPath + "/images",  extention);
            //    employee.Photo.CopyTo( new FileStream(ImgPath, FileMode.Create));

            string uploadFolder = Path.Combine(_environment.WebRootPath, "images");
            Name = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
            string filePath = Path.Combine(uploadFolder, Name);
            employee.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            _context.EmployeeTaabl.Add(employee);
            _context.SaveChanges();
           
        }


        public EmployeeModel Delete(int Id)
        {
            EmployeeModel employee = _context.EmployeeTaabl.Find(Id);

            if (employee != null)
            {
                _context.EmployeeTaabl.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }

        public EmployeeModel GetEmployee(int Id)
        {
            return _context.EmployeeTaabl.Find(Id);
        }

        public void Edit(EmployeeModel employee)
        {
           
            
            
                _context.Update(employee);
                _context.SaveChanges();

        }

        public IQueryable<EmployeeModel> Search (string surname)
        {

            //return _context.EmployeeTable.Where(T => T.FirstName.Contains(surname));
           var temp = _context.EmployeeTaabl.Where(T =>T.FirstName.Contains(surname) || T.LasttName.Contains(surname) || T.Email.Contains(surname));

            return temp;
        }

        public void AddDepartment(Department department)
        {

            _context.DepartmentTabl.Add(department);
            _context.SaveChanges();
        }
    }
}
