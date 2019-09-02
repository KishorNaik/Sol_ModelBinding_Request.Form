using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Model_Binding_RequestForm.Models;

namespace Sol_Model_Binding_RequestForm.Controllers
{
    public class UsersController : Controller
    {

        [BindProperty]
        public UserModel Users { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnSubmit()
        {
            // Get Hidden Value from Using Request Form
            string hiddenData = base.HttpContext.Request.Form["hiddenField"][0]; // "SOME_VALUE"

            return View("Index");
        }
    }
}