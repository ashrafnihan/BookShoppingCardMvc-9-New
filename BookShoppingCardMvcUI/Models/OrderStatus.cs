using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookShoppingCardMvcUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    { public int Id { get; set; }
        [Required,MaxLength(0)]
        public string? StatusName { get; set; }
       
    }
}
