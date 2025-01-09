using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName="nvarchar(100)")]
        public string Name { get; set; } 

        public ICollection<Borrow> Borrows { get; set; } 
    }
}
