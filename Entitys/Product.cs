using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Entitys
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column("ProductName",TypeName ="Varchar")]
        public string? Name { get; set; }

        public double? price { get; set; }   
    }
}
