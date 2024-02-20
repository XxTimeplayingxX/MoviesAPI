using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Peliculas_Generos_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Generos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistaPeliculas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistaID = table.Column<int>(type: "int", nullable: false),
                    PeliculaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistaPeliculas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtistaPeliculas_Artistas_ArtistaID",
                        column: x => x.ArtistaID,
                        principalTable: "Artistas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistaPeliculas_Peliculas_PeliculaID",
                        column: x => x.PeliculaID,
                        principalTable: "Peliculas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistaPeliculas_ArtistaID",
                table: "ArtistaPeliculas",
                column: "ArtistaID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistaPeliculas_PeliculaID",
                table: "ArtistaPeliculas",
                column: "PeliculaID");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_GeneroID",
                table: "Peliculas",
                column: "GeneroID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistaPeliculas");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
