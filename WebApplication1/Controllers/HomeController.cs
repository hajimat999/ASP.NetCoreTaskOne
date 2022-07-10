using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers 
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Testimonial model = new Testimonial
            {
                Id = 1,
                Title = "Testimonials",
                Desc = "Necessitatibus eius consequatur ex aliquid fuga eum quidem",
                Image1 = "testimonials-1.jpg",
                Image2 = "testimonials-2.jpg",
                Image3 = "testimonials-3.jpg",
                Image4 = "testimonials-4.jpg",
                Image5 = "testimonials-5.jpg",
                Name1 = "Saul Goodman",
                Name2 = "Sara Wilsson",
                Name3 = "Jena Karlis",
                Name4 = "Matt Brandon",
                Name5 = "John Larson"
            };
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
