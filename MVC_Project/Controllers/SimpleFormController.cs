using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC1.Controllers
{
    public class SimpleFormController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SuccessMsg()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeJsonFile(SimpleForm simpleForm)
        {
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "simpleformData.json");
                var jsonData = JsonSerializer.Serialize(simpleForm);
                System.IO.File.WriteAllText(filePath, jsonData);
                TempData["FilePath"] = filePath;
                return RedirectToAction("SuccessMsg");
            }
            else
            {
                return View("Index");
            }
        }
    }
}

