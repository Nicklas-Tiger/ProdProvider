using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;

public class ProductRegistrationForm
{
    public string? ArticleNumber { get; set; }
    [Required]
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    [Required]
    public string Price { get; set; } = null!;

}

public class ProductEntity
{
    [Key]
    public int Id { get; set; }
    public string? ArticleNumber { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string? ArticleNumber { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}
