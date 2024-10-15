using dotnet_mvc.Models;
using Microsoft.AspNetCore.Identity;

namespace dotnet_mvc.Models;
public class Cart
{
    public int Id { get; set; }
    
    // Foreign key to User
    public string UserId { get; set; }
    public IdentityUser User { get; set; }

    // Foreign key to Product
    public int ProductId { get; set; }
    public Product Product { get; set; }

    // Additional fields
    public int Quantity { get; set; }
    public DateTime DateAdded { get; set; }
}