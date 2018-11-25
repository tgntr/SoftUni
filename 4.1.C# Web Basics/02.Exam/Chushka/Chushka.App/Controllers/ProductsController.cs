using Chushka.App.Models;
using Chushka.Models;
using Microsoft.EntityFrameworkCore;
using SoftUni.WebServer.Mvc.Attributes.HttpMethods;
using SoftUni.WebServer.Mvc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chushka.App.Controllers
{
    public class ProductsController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ProductBindingModel model)
        {

            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                return this.BuildErrorView();
            }

            var product = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                TypeId = model.ProductType
            };

            using (this.Context)
            {
                this.Context.Products.Add(product);
                this.Context.SaveChanges();
            }

            return this.RedirectToAction($"/products/details?id={product.Id}");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            var product = this.Context.Products.Include(p => p.Type).FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return this.BuildErrorView();
            }
            this.ViewData["adminActions"] = "";
            this.ViewData["name"] = product.Name;
            this.ViewData["type"] = product.Type.Name;
            this.ViewData["price"] = product.Price.ToString("F2");
            this.ViewData["description"] = product.Description;

            if (this.User.IsInRole("Admin"))
            {
                this.ViewData["adminActions"] = $@"<div class=""product-action-holder mt-4 d-flex justify-content-around"">
        <a class=""btn chushka-bg-color"" href=""/products/edit?id={id}"">Edit</a>
    </div>
<div class=""product-action-holder mt-4 d-flex justify-content-around"">
        <a class=""btn chushka-bg-color"" href=""/products/delete?id={id}"">Delete</a>
    </div>";

            }

            return this.View();


        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            var product = this.Context.Products.Include(p => p.Type).FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return this.BuildErrorView();
            }
            this.ViewData["id"] = id.ToString();
            this.ViewData["name"] = product.Name;
            this.ViewData["price"] = product.Price.ToString("F2");
            this.ViewData["description"] = product.Description;

            return this.View();
        }

        [HttpPost]
        public IActionResult Edit(int id, ProductBindingModel model)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            using (this.Context)
            {
                var product = this.Context.Products.FirstOrDefault(p => p.Id == id);

                if (product is null)
                {
                    return BuildErrorView();
                }

                product.Name = model.Name;
                product.Price = model.Price;
                product.Description = model.Description;
                product.TypeId = model.ProductType;

                this.Context.SaveChanges();
            }

            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            var product = this.Context.Products.Include(p => p.Type).FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return this.BuildErrorView();
            }

            this.ViewData["id"] = id.ToString();
            this.ViewData["name"] = product.Name;
            this.ViewData["type"] = product.Type.Name;
            this.ViewData["price"] = product.Price.ToString("F2");
            this.ViewData["description"] = product.Description;

            return this.View();
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            using (this.Context)
            {
                var product = this.Context.Products.FirstOrDefault(p => p.Id == id);

                if (product is null)
                {
                    return this.BuildErrorView();
                }

                this.Context.Products.Remove(product);
                this.Context.SaveChanges();
            }

            return this.RedirectToHome();
        }

        public IActionResult Order(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.RedirectToAction("/users/login");
            }

            if (!this.User.IsInRole("Admin"))
            {
                return this.RedirectToHome();
            }

            var product = this.Context.Products.Include(p => p.Type).FirstOrDefault(p => p.Id == id);

            if (product is null)
            {
                return this.BuildErrorView();
            }

            using (this.Context)
            {
                var order = new Order()
                {
                    Id = new Guid(),
                    ClientId = this.User.Id,
                    ProductId = id,
                    OrderedOn = DateTime.Now
                };


                this.Context.Orders.Add(order);
            }

            return this.RedirectToHome();
        }

    }
}
