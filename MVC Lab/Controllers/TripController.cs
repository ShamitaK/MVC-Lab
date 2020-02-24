using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MileageForm()
        {
            return View();
        }
        
        //do not name objects the name of peoperties within
        public IActionResult MileageResult(Tripometer trips)
        {
            //Tripometer trip = new Tripometer
            //trips.MPG = mpg
            //trips.Gallons = gallons
            //trips.Trip = trip
            return View(trips);
        }
    }
}