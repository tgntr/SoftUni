using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new ShoppingListDbContext())
            {
                var products = db.Products.ToList();

                return View(products);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (product == null)
            {
                return RedirectToAction("Index");
            }

            if (string.IsNullOrWhiteSpace(product.Priority.ToString()) || string.IsNullOrWhiteSpace(product.Name) || string.IsNullOrWhiteSpace(product.Quantity.ToString()) || string.IsNullOrWhiteSpace(product.Name))
            {
                return RedirectToAction("Index");
            }

            using (var db = new ShoppingListDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            using (var db = new ShoppingListDbContext())
            {
                var product = db.Products.Find(id);
                return View(product);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            using (var db = new ShoppingListDbContext())
            {
                var product = db.Products.Find(id);

                if (product == null)
                {
                    return RedirectToAction("Index");
                }

                if (string.IsNullOrWhiteSpace(product.Priority.ToString()) || string.IsNullOrWhiteSpace(product.Name) || string.IsNullOrWhiteSpace(product.Quantity.ToString()) || string.IsNullOrWhiteSpace(product.Status))
                {
                    return RedirectToAction("Index");
                }

                product.Priority = productModel.Priority;
                product.Name = productModel.Name;
                product.Quantity = productModel.Quantity;
                product.Status = productModel.Status;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}