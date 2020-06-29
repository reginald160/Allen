using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Allen.Controllers
{
    public class AboutUsController : Controller
    {
        public  DBcontext _dBcontext = null;

       
        public IActionResult Index()
        {
            _dBcontext = new DBcontext();
            ViewBag.StatesList = new SelectList(GetAllStates(), "StateId", "StateName");
            return View ();

        }


        public List<States> GetAllStates()
        {
            
            return _dBcontext.GetAllStates();
        }

        public List<Outlets> GetAllOutLets(States id)
        {
            var selectList = _dBcontext.GetAllOutLets().Where(x => x.Id == id).ToList();
            ViewBag.ListOutlets = new SelectList(selectList, "Id", "");
            return _dBcontext.GetAllOutLets();

        }
    }
}
