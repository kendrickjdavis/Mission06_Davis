using System.ComponentModel.DataAnnotations;

namespace joelWeb.Models
{
    public class Category
    {
        
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        
    }
}
