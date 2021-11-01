using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phase4PizzaPortal.Models;

namespace Phase4PizzaPortal.Controllers
{
    public class PizzaController : Controller
    {
        private static readonly PizzaBO _context = new PizzaBO();

        public IActionResult Index()
        {
            return View(_context.GetAllPizzas());
        }

        public IActionResult Details(int id)
        {
            return View(_context.GetPizzaById(id));
        }

        public IActionResult Order(int id)
        {
            ViewBag.name = _context.GetPizzaById(id).PName;
            ViewBag.price = _context.GetPizzaById(id).PPrice;
            ViewBag.total = _context.GetPizzaById(id).PPrice;
            return View();
        }

        public IActionResult status()
        {
            return View();
        }

    }
}
