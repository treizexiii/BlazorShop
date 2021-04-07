using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorShop.Shared
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int EditionId { get; set; }
        public string ProductTitle { get; set; }
        public string EditionName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}