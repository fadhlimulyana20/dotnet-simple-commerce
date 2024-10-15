using dotnet_mvc.Data;
using dotnet_mvc.Models;
using dotnet_mvc.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

public class CartController : Controller
{
    private readonly DotnetMvcContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public CartController(DotnetMvcContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // View the cart
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var cartItems = _context.Carts
            .Where(c => c.UserId == user.Id)
            .Select(c => new CartItemViewModel
            {
                ProductName = c.Product.Name,
                Price = c.Product.Price,
                ImgUrl = c.Product.ImgUrl,
                ProductSku =c.Product.Sku,
                Quantity = c.Quantity
            }).ToList();

        var cartViewModel = new CartViewModel
        {
            CartItems = cartItems,
        };

        return View(cartViewModel);
    }

    // Add a product to the cart
    [HttpPost]
    public async Task<IActionResult> AddToCart(int productId)
    {
        var user = await _userManager.GetUserAsync(User);

        var cartItem = _context.Carts
            .FirstOrDefault(c => c.UserId == user.Id && c.ProductId == productId);

        if (cartItem != null)
        {
            // Product is already in the cart, increase quantity
            cartItem.Quantity++;
        }
        else
        {
            // Add new item to the cart
            var newCartItem = new Cart
            {
                UserId = user.Id,
                ProductId = productId,
                Quantity = 1,
                DateAdded = DateTime.Now
            };

            _context.Carts.Add(newCartItem);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    // Remove a product from the cart
    [HttpPost]
    public async Task<IActionResult> RemoveFromCart(int productId)
    {
        var user = await _userManager.GetUserAsync(User);

        var cartItem = _context.Carts
            .FirstOrDefault(c => c.UserId == user.Id && c.ProductId == productId);

        if (cartItem != null)
        {
            _context.Carts.Remove(cartItem);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction("Index");
    }
}
