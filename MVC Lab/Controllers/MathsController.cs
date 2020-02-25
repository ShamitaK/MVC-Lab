using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class MathsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNumbers(int num1, int num2)
        {
            string sum = Maths.Add(num1, num2);
            return View("Results", sum);
        }

        [HttpGet]
        public IActionResult DivideNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DivideNumbers(int num1, int num2)
        {
            string divideNum = Maths.Divide(num1, num2);
            return View("Results", divideNum);
        }

        public IActionResult Results()
        {
            return View("");
        }

    }
}