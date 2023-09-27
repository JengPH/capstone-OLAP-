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

namespace Capstone_Olapp.Controllers
{
    public class AuthedController : Controller
    {
        private  UserManager<ApplicationUser> _usrMngr;
        private  SignInManager<ApplicationUser> _signInMngr;
        private readonly KaskwekContext _context;

        public AuthedController(UserManager<ApplicationUser> usrMngr, SignInManager<ApplicationUser> signInMngr, KaskwekContext context)
        {
            _usrMngr = usrMngr;
            _signInMngr = signInMngr;
            _context = context;
        }
        public IActionResult Index(){
            if(!User.Identity.IsAuthenticated){
                return RedirectToAction("LoginIndex","Account");
            }
            return View();
        }

    }
}