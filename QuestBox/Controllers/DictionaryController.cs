using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestBox.Models;
using QuestBox.Models.Core;

namespace QuestBox.Controllers
{
    public class DictionaryController : BaseController
    {
        public DictionaryController(QuestBoxDbContext questBoxDbContext, ILogger<HomeController> logger) 
            : base(questBoxDbContext, logger)
        {
        }

        public IActionResult Index(string DictionaryName)
        {
            ICrud currentModel = GetModel(DictionaryName);
            ViewData.Model = currentModel.GetElements();
            SetdefautValues(currentModel, DictionaryName);
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id, string DictionaryName)
        {
            ICrud currentModel = GetModel(DictionaryName);
            if (id > 0)
            {
                ViewData.Model = currentModel.GetElement(id);
            }
            else
            {
                ViewData.Model = currentModel.NewElement();
            }
            SetdefautValues(currentModel, DictionaryName);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(string DictionaryName, Dictionary<string,string> Values)
        {
            ICrud currentModel = GetModel(DictionaryName);
            currentModel.EditElement(Values);
            SetdefautValues(currentModel, DictionaryName);
            return RedirectToAction("Index", DictionaryName);
        }
        public void SetdefautValues(ICrud crud,string DictionaryName)
        {
            ViewBag.Headlines = crud.GetHeadersOfTable();
            ViewBag.DictionaryName = DictionaryName;
        }
        private ICrud GetModel(string DictionaryName)
        {
            ICrud _return = null;
            switch (DictionaryName.ToLower())
            {
                case "users":
                    _return = new UsersCrud(_questBoxDbContext,_questBoxDbContext.Users);
                    break;
                case "comands":
                    _return = new CrudComand(_questBoxDbContext, _questBoxDbContext.Comands);
                    break;
                default:
                    break;
            }
            return _return;
        }
    }
}