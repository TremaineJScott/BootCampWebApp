using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootCampWebApp.Models;

namespace BootCampWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string name = "shoes", string description = "new shoes")
        {
            ProductViewModel product = new ProductViewModel() 
            { 
                Name = name, 
                Description = description
            };
            ViewBag.Category = "Outdoor Gear";
            ViewBag.Price = 4.50;
            

            List<ProductViewModel> productList = new List<ProductViewModel>()
            {
                new ProductViewModel{Name = "pant", Description = "cover leg"},
                new ProductViewModel{Name = "other pant", Description = "cover other leg"}
            };

            ViewData["product"] = productList;

            return View(product);
        }

        public IActionResult Details()
        {
            ProductViewModel product = new ProductViewModel()
            {
                Name = "this name",
                Description = "this description"
            };
            return View(product);
        }

        public string Message()
        {
            return $"Todays date is {GetDate()}";
        }

       private DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
