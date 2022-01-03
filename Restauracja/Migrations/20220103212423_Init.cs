using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restauracja.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    KlientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumerStolika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.KlientId);
                });

            migrationBuilder.CreateTable(
                name: "PozycjeZamowienia",
                columns: table => new
                {
                    IdPozycji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zdjecie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriaPozycji = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozycjeZamowienia", x => x.IdPozycji);
                });

            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    IdPracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImiePracownika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwiskoPracownika = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.IdPracownika);
                });

            migrationBuilder.CreateTable(
                name: "Zamownies",
                columns: table => new
                {
                    IdZamownie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataZamowienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CenaZamowniena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPracownika = table.Column<int>(type: "int", nullable: false),
                    PracownikIdPracownika = table.Column<int>(type: "int", nullable: true),
                    KlientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamownies", x => x.IdZamownie);
                    table.ForeignKey(
                        name: "FK_Zamownies_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "KlientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamownies_Pracownicy_PracownikIdPracownika",
                        column: x => x.PracownikIdPracownika,
                        principalTable: "Pracownicy",
                        principalColumn: "IdPracownika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie_PozycjaZamowienias",
                columns: table => new
                {
                    IdZamownie = table.Column<int>(type: "int", nullable: false),
                    IdPozycji = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie_PozycjaZamowienias", x => new { x.IdZamownie, x.IdPozycji });
                    table.ForeignKey(
                        name: "FK_Zamowienie_PozycjaZamowienias_PozycjeZamowienia_IdPozycji",
                        column: x => x.IdPozycji,
                        principalTable: "PozycjeZamowienia",
                        principalColumn: "IdPozycji",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_PozycjaZamowienias_Zamownies_IdZamownie",
                        column: x => x.IdZamownie,
                        principalTable: "Zamownies",
                        principalColumn: "IdZamownie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_PozycjaZamowienias_IdPozycji",
                table: "Zamowienie_PozycjaZamowienias",
                column: "IdPozycji");

            migrationBuilder.CreateIndex(
                name: "IX_Zamownies_KlientId",
                table: "Zamownies",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamownies_PracownikIdPracownika",
                table: "Zamownies",
                column: "PracownikIdPracownika");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zamowienie_PozycjaZamowienias");

            migrationBuilder.DropTable(
                name: "PozycjeZamowienia");

            migrationBuilder.DropTable(
                name: "Zamownies");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Pracownicy");
        }
    }
}
