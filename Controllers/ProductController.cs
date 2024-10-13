using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc.Models;

namespace dotnet_mvc.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() 
    {
        return View();
    }
}