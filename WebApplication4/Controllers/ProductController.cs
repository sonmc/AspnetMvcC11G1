using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>();
        public List<Product> DataInit()
        {
            products.Add(new Product() { Id = 1, Name = "Iphone xsmax", Price = 13.5f });
            products.Add(new Product() { Id = 1, Name = "Samsung Galaxy", Price = 18.5f });
            return products;
        }
        public IActionResult Index()
        {
            products = DataInit();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            products = DataInit();
            Product productUpdate = new Product();
            foreach (var item in products)
            {
                productUpdate = item;
            }
            ViewData["ProductUpdate"] = productUpdate;
            return View();
        }

        public ActionResult Delete(int id)
        {
            products = DataInit();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.ProductDeleted = product;
            return View();
        } 
    }
}
