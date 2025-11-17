using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductsApi.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "NUMBER(18,2)")]
        public decimal Price { get; set; }

        [MaxLength(100)]       
        public string? Category { get; set; }

        [NotMapped]       
        public ICollection<Order>? Orders { get; set; } = new List<Order>();


    }
}
