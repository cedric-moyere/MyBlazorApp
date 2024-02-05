using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Data
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }
    }
}