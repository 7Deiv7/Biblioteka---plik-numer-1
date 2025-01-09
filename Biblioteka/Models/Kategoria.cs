namespace Biblioteka.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relacja z tabelą Books
        public ICollection<Book> Books { get; set; }
    }
}
