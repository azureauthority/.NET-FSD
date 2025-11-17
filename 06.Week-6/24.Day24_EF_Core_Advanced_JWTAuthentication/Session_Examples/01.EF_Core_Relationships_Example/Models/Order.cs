using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductsApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate {  get; set; }

       [ForeignKey("Product")]
       public int ProductId { get; set; }

        public int Quanity { get; set; }

        [NotMapped]      
        // Navigation Property
        public Product? Product {  get; set; }
    }
}
