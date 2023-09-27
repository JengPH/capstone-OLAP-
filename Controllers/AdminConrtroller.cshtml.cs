using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Capstone_Olapp.Models;
using Capstone_Olapp.Identity;
using Microsoft.Extensions.Logging;

namespace Capstone_Olapp.Controllers
{
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _usrMngr;
        private SignInManager<ApplicationUser> _signInMngr;
        public AdminController(UserManager<ApplicationUser> usrMngr, SignInManager<ApplicationUser> signInMngr)
        {
            _usrMngr = usrMngr;
            _signInMngr = signInMngr;
            // _context = context;
        }
        [HttpGet]
        public IActionResult LoginIndex()
        {
            return View("Account/LoginIndex");
        }

        public IActionResult MainDashboard()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            return View("MainDashboard");
        }



    }
}