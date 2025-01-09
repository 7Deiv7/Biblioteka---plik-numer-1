using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteka.Migrations
{
    /// <inheritdoc />
    public partial class DodajKategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriaId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Komedia" },
                    { 2, "Akcja" },
                    { 3, "Dramat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_KategoriaId",
                table: "Books",
                column: "KategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Kategorie_KategoriaId",
                table: "Books",
                column: "KategoriaId",
                principalTable: "Kategorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Kategorie_KategoriaId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropIndex(
                name: "IX_Books_KategoriaId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "KategoriaId",
                table: "Books");
        }
    }
}
