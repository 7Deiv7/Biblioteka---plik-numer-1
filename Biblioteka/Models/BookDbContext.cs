using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        // DbSet dla tabel
        public DbSet<Book> Books { get; set; } // Tabela dla książek
        public DbSet<Author> Authors { get; set; } // Tabela dla autorów
        public DbSet<Borrow> Borrows { get; set; } // Tabela dla wypożyczeń
        public DbSet<User> Users { get; set; } // Tabela dla użytkowników

        public DbSet<Kategoria> Kategorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracja relacji między tabelami

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Kategoria)
                .WithMany(k => k.Books)
                .HasForeignKey(b => b.KategoriaId)
                .OnDelete(DeleteBehavior.Cascade); 

            base.OnModelCreating(modelBuilder);

            // Seed dla kategorii
            modelBuilder.Entity<Kategoria>().HasData(
            new Kategoria { Id = 1, Name = "Komedia" },
            new Kategoria { Id = 2, Name = "Akcja" },
            new Kategoria { Id = 3, Name = "Dramat" }
            );

            // Seed dla książek
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Książka 1",
                    KategoriaId = 1,
                    Isbn = "1234567890120",
                    AuthorId = 1,
                },
                new Book
                {
                    Id = 2,
                    Title = "Książka 2",
                    KategoriaId = 2,
                    Isbn = "1234567890123",
                    AuthorId = 2,
                }
            );

            // Seed dla autorów
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Autor 1" },
                new Author { AuthorId = 2, Name = "Autor 2" }
            );

        }



        

    }


}

