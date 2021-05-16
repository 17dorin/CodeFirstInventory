using CodeFirstPractice2.Context;
using CodeFirstPractice2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventoryDbContext _context;

        public HomeController(ILogger<HomeController> logger, InventoryDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Item i)
        {
            if(!_context.Items.Contains(i))
            {
                _context.Items.Add(i);
                await _context.SaveChangesAsync();
                return RedirectToAction("ViewInventory");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult ViewInventory()
        {
            List<Item> inventory = _context.Items.ToList();

            return View(inventory);
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
