using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCourse.Spyshop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.Spyshop.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {

            var viewModel = new AboutIndexVm();

            viewModel.ContactEmail = "info@spyshop.example";
            viewModel.CompanyFullName = "Spy Shop Incorperated";
            viewModel.AboutTitle = "Welcome to Spy Shop";
            viewModel.AboutContent = "<p>We deliver premium gadgets to help all Clouseaus and Bonds out there.<br />To start, have a loot at the <a href=\"/\">homepage</a>!</p>";

            return View(viewModel);
        }
    }
}