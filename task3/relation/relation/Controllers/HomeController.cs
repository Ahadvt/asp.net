using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relation.Controllers
{
    public class HomeController:Controller
    {

        private readonly AddDbContext _context;
        public HomeController(AddDbContext context)
        {
            _context = context;

        }
        public ActionResult Index()
        {
            List<Group> groups = _context.Groups.Include(b=>b.students).ToList();
            return View(groups);
        }

        public ActionResult Details(int id)
        {
          Group group = _context.Groups.Include(b =>b.students).FirstOrDefault(g => g.Id == id);
            
            if (group==null)
            {
                return Content("theris not group");
            }
            return View(group);

        }
    }
}
