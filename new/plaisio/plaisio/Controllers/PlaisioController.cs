using plaisio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace plaisio.Controllers
{
    public class PlaisioController : Controller
    {
        // GET: Plaisio
        public ActionResult Laptops()
        {
            List<Product> products = new List<Product>();

            Product laptop1 = new Product() { Id = 1, Name = "Asus", ImgUrl = "https://cdn.plaisio.gr/mms/Product-Images/PlaisioGr/3/3/5/5/8/2/9/3355829.jpg?h=800&w=800&hash=BCDE723F17E35EC57705C3FF9B662591D28976EC" };
            Product laptop2 = new Product() { Id = 2, Name = "Hp", ImgUrl = "https://cdn.plaisio.gr/mms/Product-Images/PlaisioGr/3/2/6/5/1/0/2/3265102.jpg?h=800&w=800&hash=753BA1F77625974635AF457907EC8F5F1538B554" };
            Product laptop3 = new Product() { Id = 3, Name = "Apple", ImgUrl = "https://cdn.plaisio.gr/mms/Product-Images/PlaisioGr/2/7/0/1/1/6/2/2701162.jpg?h=800&w=800&hash=FB4B02DD08FB3BFD88255F445CC930FE49DBE46D" };
            Product laptop4 = new Product() { Id = 4, Name = "Dell", ImgUrl = "https://cdn.plaisio.gr/mms/Product-Images/PlaisioGr/3/2/7/3/7/3/3/3273733.jpg?h=800&w=800&hash=956201397D191F634790D17A92629F7994EFD3F6" };
            Product laptop5 = new Product() { Id = 5, Name = "Lenovo", ImgUrl = "https://cdn.plaisio.gr/mms/Product-Images/PlaisioGr/3/3/0/6/6/3/1/3306631.jpg?h=800&w=800&hash=2B766F02BD5BEA246F83199A355FC0C5559C5D8B" };

            products.Add(laptop1);
            products.Add(laptop2);
            products.Add(laptop3);
            products.Add(laptop4);
            products.Add(laptop5);

            ViewBag.Products = products;

            return View(products);
        }
    }
}