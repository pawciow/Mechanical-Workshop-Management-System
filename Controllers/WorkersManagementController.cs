using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mechanical_Workshop_Management_System.Controllers
{
    public class WorkersManagementController : Controller
    {
        public IActionResult Index()
        {
            return View("WorkersManagement");
        }
    }
}
