using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlazorApp.Data
{
    public class Sale
    {
        [Key]
        public string SaleId { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(IdentityUser))]
        public string UserId { get; set; }

        public IdentityUser User { get; set; }

        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}