using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.ViewModels
{
    public class ModifyCartViewModel
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}