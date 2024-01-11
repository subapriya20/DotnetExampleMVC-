using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FoodApplication.ModelExpressionProvider
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? RecipeId { get; set; }
        [Required]
        public string? RecipeName{ get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int TotalAmount { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}