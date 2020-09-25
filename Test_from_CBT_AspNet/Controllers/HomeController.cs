using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test_from_CBT_AspNet.Data;
using Test_from_CBT_AspNet.Models;

namespace Test_from_CBT_AspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Test_from_CBT_AspNetContext _context;
        public HomeController(ILogger<HomeController> logger, Test_from_CBT_AspNetContext db)
        {
            _logger = logger;
            _context = db;
        }
        public IActionResult Index()
        {
            return View(_context.AspNetEvents.ToList());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
