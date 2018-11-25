using SoftUni.WebServer.Mvc.Attributes.HttpMethods;
using SoftUni.WebServer.Mvc.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chushka.App.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (!this.User.IsAuthenticated)
            {
                this.ViewData["indexView"] = @"<main>
        <div class=""jumbotron mt-3 chushka-bg-color"" >
            <h1>Welcome to Chushka Universal Web Shop</h1>
            <hr class=""bg-white"" />
            <h3><a class=""nav-link-dark"" href =""/users//login"" > Login</a> if you have an account.</h3>
            <h3><a class=""nav-link-dark"" href=""/users/register"">Register</a> if you don't.</h3>
        </div>
    </main>";
            }
            else
            {
                this.ViewData["indexView"] = "products";
            }

            return this.View();
        }
    }
}
