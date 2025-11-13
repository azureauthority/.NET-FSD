using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate {  get; set; }

       public int ProductId { get; set; }

        public int Quanity { get; set; }

        public Product? Product {  get; set; }
    }
}
