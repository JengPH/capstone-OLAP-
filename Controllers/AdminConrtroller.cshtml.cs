using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Capstone_Olapp.Controllers
{
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult LoginIndex()
        {
            return View("PartialLogin/LoginIndex");
        }

    }
}