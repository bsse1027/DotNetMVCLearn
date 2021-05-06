using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {

            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category; 
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }




    }
}
