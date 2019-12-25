using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestBox.Models;

namespace QuestBox.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger<HomeController> _logger;
        protected readonly QuestBoxDbContext _questBoxDbContext;
        public BaseController(QuestBoxDbContext questBoxDbContext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _questBoxDbContext = questBoxDbContext;
        }
    }
}