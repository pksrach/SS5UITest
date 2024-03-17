using System.ComponentModel.DataAnnotations;

namespace SS5UITest.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
