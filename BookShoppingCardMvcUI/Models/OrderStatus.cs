using System.ComponentModel.DataAnnotations;


namespace BookShoppingCardMvcUI.Models
{
    public class OrderStatus
    { public int Id { get; set; }
        [Required,MaxLength(0)]
        public string? StatusName { get; set; }
       
    }
}
