using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Sku { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImgUrl { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    [DataType(DataType.Date)]
    public DateTime UpdatedAt { get; set; }
    
    public Product()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}