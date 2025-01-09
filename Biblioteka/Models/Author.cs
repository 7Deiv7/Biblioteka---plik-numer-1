using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [Column(TypeName="nvarchar(100)")]
        public string Name { get; set; } 

        public ICollection<Book> Books { get; set; } 
    }
}
