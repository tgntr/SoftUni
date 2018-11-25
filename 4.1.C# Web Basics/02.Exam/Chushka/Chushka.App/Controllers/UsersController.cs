using Chushka.App.Models;
using Chushka.Models;
using Microsoft.EntityFrameworkCore;
using SoftUni.WebServer.Common;
using SoftUni.WebServer.Mvc.Attributes.HttpMethods;
using SoftUni.WebServer.Mvc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chushka.App.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public IActionResult Register()
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterBindingModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                return this.BuildErrorView();
            }

            if (model.Password != model.ConfirmPassword || this.Context.Users.Any(u => u.Username == model.Username || u.Email == model.Email))
            {
                return this.BuildErrorView();
            }

            var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

            var user = new User()
            {
                Username = model.Username,
                PasswordHash = passwordHash,
                Email = model.Email,
                FullName = model.FullName
            };

            using (this.Context)
            {
                if (!this.Context.Users.Any())
                {
                    user.RoleId = 1;
                }
                else
                {
                    user.RoleId = 2;
                }

                this.Context.Users.Add(user);
                this.Context.SaveChanges();
            }

            var roles = new List<string>() { user.Role.Name };
            this.SignIn(user.Username, user.Id, roles);
            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginBindingModel model)
        {


            if (!this.IsValidModel(model))
            {
                return this.BuildErrorView();
            }

            User user;

            using (this.Context)
            {
                var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

                user = this.Context.Users.Include(u => u.Role).FirstOrDefault(u => u.Username == model.Username && u.PasswordHash == passwordHash);

                if (user is null)
                {
                    return this.BuildErrorView();
                }
            }
            var roles = new List<string>() { user.Role.Name };
            this.SignIn(user.Username, user.Id, roles);
            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            if (this.User.IsAuthenticated)
            {
                this.SignOut();
            }

            return RedirectToHome();
        }
    }
}
