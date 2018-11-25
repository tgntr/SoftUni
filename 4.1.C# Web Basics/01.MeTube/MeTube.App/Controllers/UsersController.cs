

namespace MeTube.App.Controllers
{
    using MeTube.App.Models;
    using MeTube.Models;
    using SimpleMvc.Common;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Attributes.Security;
    using SimpleMvc.Framework.Interfaces;
    using System;
    using System.Linq;

    public class UsersController:BaseController
    {
        [HttpGet]
        public IActionResult Register()
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            return View();
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

            if (this.Context.Users.Any(u => u.Username == model.Username || u.Email == model.Email)) 
            {
                this.BuildErrorView("Username and/or email already registered");
                return this.View();
            }
            else if(model.Password != model.ConfirmPassword)
            {
                this.BuildErrorView("Passwords do not match!");
                return this.View();
            }

            var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

            var user = new User()
            {
                Username = model.Username,
                PasswordHash = passwordHash,
                Email = model.Email
            };

            

            using (this.Context)
            {
                this.Context.Users.Add(user);
                this.Context.SaveChanges();
            }

            this.SignIn(user.Username, user.Id);
            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginBindingModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                return this.BuildErrorView();
            }

            User user;

            using (this.Context)
            {
                var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

                user = this.Context.Users.FirstOrDefault(u => u.Username == model.Username && u.PasswordHash == passwordHash);

                if (user is null)
                {
                    this.BuildErrorView("Username and password do not match!");
                    return this.View();
                }
            }

            this.SignIn(user.Username, user.Id);
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

        [HttpGet]
        [PreAuthorize]
        public IActionResult Profile()
        {
            this.Model.Data["username"] = DbUser.Username;
            this.Model.Data["email"] = DbUser.Email;

            var tubesAsProfileHtml =
                @"<tr>
                    <td>{0}</td>
                    <td>{1}</td>
                    <td>{2}</td>
                </tr>";
            var tubesAsHtml = this.Context.Tubes
                .Where(t => t.UploaderId == DbUser.Id)
                .Select(t =>
                    string.Format(tubesAsProfileHtml, 
                        t.Title, 
                        t.Author, 
                        $@"<a href=""/tubes/details?id={t.Id}"">Details</a>"))
                    .ToArray();

            this.Model.Data["tubes"] = string.Join(Environment.NewLine, tubesAsHtml);

            return View();

        }

    }
}
