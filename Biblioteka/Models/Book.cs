using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
        public class Book
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(50)")]
            public string Title { get; set; }

             [Required]
            public int AuthorId { get; set; }
            public Author Author { get; set; }

            [Required]
            [StringLength(13, MinimumLength = 13)]
            [RegularExpression(@"^\d{13}$", ErrorMessage = "Numer ISBN musi mieć 13 znaków i składać się z cyfr.")]
            public string Isbn { get; set; }

            // Klucz obcy
            public int? KategoriaId { get; set; }

            // Właściwość nawigacyjna
            public Kategoria Kategoria { get; set; }
    }
    
}
