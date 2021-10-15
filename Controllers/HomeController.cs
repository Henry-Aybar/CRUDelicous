using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicous.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicous.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController( MyContext context)
        {
            _context = context;
        }

        //=========================
        // Dispaly All Chefs
        //=========================
        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs
                .OrderBy(chef => chef.ChefId)
                .Include(chef => chef.Dishes)
                .ToList();

            return View();
        }

        //=========================
        // Dispaly All Dishes
        //=========================
        [HttpGet("/dishes")]
        public IActionResult AllDishes()
        {
            List<Dish> dishAndChef = _context.Dishes
                .Include(dish => dish.Chef)
                .ToList();

            ViewBag.AllDishes = _context.Dishes
                .OrderByDescending(dish => dish.DishId)
                .ToList();
            return View("AllDishes");
        }

        //=========================
        // NewChef Get and Post
        //=========================
        [HttpGet("/chef/new")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }
        [HttpPost("createChef")]
        public IActionResult CreateChef(Chef newChef)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //=========================
        // NewDish Get and Post
        //=========================
        [HttpGet("/dish/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View("NewDish");
        }

        [HttpPost("createDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //=========================
        //   View 1 Dish  
        //=========================
        [HttpGet("/{id}")]
        public IActionResult OneDish(int id)
        {   
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            return View();
        }

        //=========================
        //   Edit Dish
        //=========================
        [HttpGet("/{id}/edit")]
        public IActionResult EditDish(int id)
        {
            Dish OneDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            return View(OneDish);
        }

        [HttpPost("/dish/submitEdit")]
        public IActionResult UpdateDish(Dish EditedDish)
        {
            Dish editMe = _context.Dishes.FirstOrDefault(dish => dish.DishId == EditedDish.DishId);

            editMe.DishName = EditedDish.DishName;
            editMe.Calories = EditedDish.Calories;
            editMe.Taste = EditedDish.Taste;
            editMe.Description = EditedDish.Description;
            editMe.UpdatedAt = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //=========================
        //   Delete Dish
        //=========================
        [HttpGet("/{id}/delete")]
        public IActionResult DeleteDish(int id)
        {
            Dish deleteMe = _context.Dishes.SingleOrDefault(bye => bye.DishId == id);
            _context.Dishes.Remove(deleteMe);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}