using dotnet_mvc.Data;
using dotnet_mvc.Models;
using dotnet_mvc.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_mvc.Controllers {
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
            if (user == null) 
            {
                return RedirectToAction("Login", "Auth"); // Redirect to login page if not logged in
            }

            var cartItems = _context.Carts
                .Where(c => c.UserId == user.Id)
                .Select(c => new CartItemViewModel
                {
                    ProductId = c.Product.Id,
                    ProductName = c.Product.Name,
                    Price = c.Product.Price,
                    ImgUrl = c.Product.ImgUrl,
                    ProductSku = c.Product.Sku,
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

        // Modify quantity action
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(ModifyCartViewModel model)    
        {
            if (ModelState.IsValid) {
                var user = await _userManager.GetUserAsync(User);

                var cartItem = _context.Carts
                    .FirstOrDefault(c => c.UserId == user.Id && c.ProductId == model.ProductId);

                if (cartItem != null)
                {
                    // Update the quantity of the cart item
                    cartItem.Quantity = model.Quantity;

                    // Save changes to the database
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }

                return NotFound();
            }

            return View(model);
        }
    }
}
