using System.Collections.Generic;

namespace dotnet_mvc.ViewModels
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImgUrl { get; set; }
        public string ProductSku { get; set; }
        public decimal Subtotal => Price * Quantity;
    }

    public class CartViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; } = new List<CartItemViewModel>();
        public decimal TotalBill => CartItems.Sum(item => item.Subtotal);
    }
}
