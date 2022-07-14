using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class dbTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klienti");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Transportuesi");

            migrationBuilder.DropTable(
                name: "Restauranti");

            migrationBuilder.DropTable(
                name: "Perdoruesi");

            migrationBuilder.DropTable(
                name: "Qyteti");

            migrationBuilder.DropTable(
                name: "Roli");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Qyteti",
                columns: table => new
                {
                    QytetiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qyteti", x => x.QytetiID);
                });

            migrationBuilder.CreateTable(
                name: "Roli",
                columns: table => new
                {
                    roliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roli", x => x.roliID);
                });

            migrationBuilder.CreateTable(
                name: "Restauranti",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_regjistrimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrYjeve = table.Column<int>(type: "int", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QytetiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restauranti", x => x.RestaurantID);
                    table.ForeignKey(
                        name: "FK_Restauranti_Qyteti_QytetiID",
                        column: x => x.QytetiID,
                        principalTable: "Qyteti",
                        principalColumn: "QytetiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perdoruesi",
                columns: table => new
                {
                    perdoruesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_telefonit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photoProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qyteti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roliID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perdoruesi", x => x.perdoruesiID);
                    table.ForeignKey(
                        name: "FK_Perdoruesi_Roli_roliID",
                        column: x => x.roliID,
                        principalTable: "Roli",
                        principalColumn: "roliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cmimi = table.Column<double>(type: "float", nullable: false),
                    Emertimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr_artikujve = table.Column<int>(type: "int", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PijaID = table.Column<int>(type: "int", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    UshqimiID = table.Column<int>(type: "int", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menu_Pija_PijaID",
                        column: x => x.PijaID,
                        principalTable: "Pija",
                        principalColumn: "PijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Restauranti_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restauranti",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Ushqimi_UshqimiID",
                        column: x => x.UshqimiID,
                        principalTable: "Ushqimi",
                        principalColumn: "UshqimiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klienti",
                columns: table => new
                {
                    klientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataLindjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nrPorosive = table.Column<int>(type: "int", nullable: false),
                    perdoruesiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienti", x => x.klientID);
                    table.ForeignKey(
                        name: "FK_Klienti_Perdoruesi_perdoruesiID",
                        column: x => x.perdoruesiID,
                        principalTable: "Perdoruesi",
                        principalColumn: "perdoruesiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transportuesi",
                columns: table => new
                {
                    transportuesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataLindjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nrPorosive = table.Column<int>(type: "int", nullable: false),
                    perdoruesiID = table.Column<int>(type: "int", nullable: false),
                    statusi_aktivitetit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportuesi", x => x.transportuesiID);
                    table.ForeignKey(
                        name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                        column: x => x.perdoruesiID,
                        principalTable: "Perdoruesi",
                        principalColumn: "perdoruesiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klienti_perdoruesiID",
                table: "Klienti",
                column: "perdoruesiID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PijaID",
                table: "Menu",
                column: "PijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantID",
                table: "Menu",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_UshqimiID",
                table: "Menu",
                column: "UshqimiID");

            migrationBuilder.CreateIndex(
                name: "IX_Perdoruesi_roliID",
                table: "Perdoruesi",
                column: "roliID");

            migrationBuilder.CreateIndex(
                name: "IX_Restauranti_QytetiID",
                table: "Restauranti",
                column: "QytetiID");

            migrationBuilder.CreateIndex(
                name: "IX_Transportuesi_perdoruesiID",
                table: "Transportuesi",
                column: "perdoruesiID");
        }
    }
}
