using Chushka.Data;
using Chushka.Models;
using Microsoft.EntityFrameworkCore;
using SoftUni.WebServer.Mvc.Controllers;
using SoftUni.WebServer.Mvc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chushka.App.Controllers
{
    public class BaseController :Controller
    {
        protected BaseController()
        {
            this.Context = new ChushkaDbContext();
            this.ViewData["error"] = "";
        }

        protected ChushkaDbContext Context { get; private set; }

        protected User DbUser { get; private set; }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/");

        public override void OnAuthentication()
        {
           



            if (!this.User.IsAuthenticated)
            {
                this.ViewData["menuView"] = 
                    @"<li class=""nav-item"" >
                        <a class=""nav-link nav-link-white"" href =""/users/login"">Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link nav-link-white"" href=""/users/register"">Register</a>
                    </li>";
            }
            if (this.User.IsAuthenticated)
            {
                this.DbUser = this.Context.Users
                    .Include(u=>u.Role)
                    .FirstOrDefault(u => u.Username == this.User.Name);

                if (this.IsAdmin())
                {
                    this.ViewData["menuView"] = @"<div class=""collapse navbar-collapse d-flex justify-content-between"" id =""navbarNav"" >
                <ul class=""navbar-nav right-side"" >
                    <li class=""nav-item"" >
                        <a class=""nav-link nav-link-white"" href =""/products/create"" >Create Product</a>
                    </li>
                    <li class=""nav-item"" >
                        <a class=""nav-link nav-link-white"" href =""/orders/all"" >All Orders</a>
                    </li>
                    
                </ul>
                <ul class=""navbar-nav left-side"" >
                    <li class=""nav-item"" >
                        <a class=""nav-link nav-link-white"" href =""/users//logout"">Logout</a>
                    </li>
                </ul>
            </div>";
                }
                else
                {
                    this.ViewData["menuView"] = @"<div class=""collapse navbar-collapse d-flex justify-content-between"" id =""navbarNav"" >
                <ul class=""navbar-nav left-side"" >
                    <li class=""nav-item"" >
                        <a class=""nav-link nav-link-white"" href =""/users/logout"">Logout</a>
                    </li>
                </ul>
            </div>";
                }
            }
            base.OnAuthentication();
        }

        protected IActionResult BuildErrorView()
        {
            this.ViewData["error"] = "You have errors in your form.";
            return this.View();
        }
        

        protected bool IsAdmin()
        {
            return this.DbUser.Role.Name == "Admin";
        }

        protected string GetRole(int id) => (id == 1) ? "Admin" : "User";
    }
}
