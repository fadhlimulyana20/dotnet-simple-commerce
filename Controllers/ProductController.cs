using dotnet_mvc.Data;
using dotnet_mvc.Models; // Assuming your Product model is in the Models folder
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace dotnet_mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly DotnetMvcContext _context; // Assuming you are using EF Core

        // Single constructor to inject both ILogger and ApplicationDbContext
        public ProductController(DotnetMvcContext context)
        {
            _context = context;
        }

        // Action for displaying the product list
        public IActionResult Index()
        {
            // Fetch the products from the database
            var products = _context.Product.ToList();

            // Pass the product list to the view
            return View(products);
        }

        // Action for displaying the product details
        public IActionResult Detail(int ID)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == ID);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
