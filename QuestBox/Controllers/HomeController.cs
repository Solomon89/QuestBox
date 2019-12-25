using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestBox.Models;

namespace QuestBox.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(QuestBoxDbContext questBoxDbContext, ILogger<HomeController> logger)
            : base(questBoxDbContext, logger)
        {
        }

        public IActionResult Index()
        {
            ViewData.Model = _questBoxDbContext.Users.ToList();
            return View();
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
