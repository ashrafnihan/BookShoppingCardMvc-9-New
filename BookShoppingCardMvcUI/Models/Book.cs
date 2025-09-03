using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCardMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }
        public double price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreID { get; set; }
        public Genre Genre;
        

    }
}
