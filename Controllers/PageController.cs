using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Capstone_Olapp.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Backend(){
            return View();
        }
    }
}