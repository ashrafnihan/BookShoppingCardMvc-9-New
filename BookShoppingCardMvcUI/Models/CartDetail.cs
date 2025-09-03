using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCardMvcUI.Models
{
    [Table("CartDetail")]    
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCart_Id { get; set; }
        [Required]
        public int Book_Id { get; set; }
        [Required]
        public int Quantity { get; set; } 
        public Book Book{ get; set; }
        public ShoppingCart ShoppingCart { get; set; }

    }
}
