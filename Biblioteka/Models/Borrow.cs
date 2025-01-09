using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowId { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        public int BookId { get; set; } 
        public Book Book { get; set; } 

        [Required] 
        public int UserId { get; set; } 
        public User User { get; set; }
    }
}
