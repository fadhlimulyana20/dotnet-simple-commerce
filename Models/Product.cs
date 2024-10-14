using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Sku { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    [DataType(DataType.Date)]
    public DateTime UpdatedAt { get; set; }
    
}