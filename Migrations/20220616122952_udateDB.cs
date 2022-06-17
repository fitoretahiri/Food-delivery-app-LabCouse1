using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class udateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "restaurant_Qyteti");

            migrationBuilder.DropTable(
                name: "Qyteti");

            migrationBuilder.DropTable(
                name: "Restauranti");
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
                name: "Restauranti",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_regjistrimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrYjeve = table.Column<int>(type: "int", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restauranti", x => x.RestaurantID);
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
                    UshqimiID = table.Column<int>(type: "int", nullable: false)
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
                name: "restaurant_Qyteti",
                columns: table => new
                {
                    QytetiID = table.Column<int>(type: "int", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant_Qyteti", x => new { x.QytetiID, x.RestaurantID });
                    table.ForeignKey(
                        name: "FK_restaurant_Qyteti_Qyteti_QytetiID",
                        column: x => x.QytetiID,
                        principalTable: "Qyteti",
                        principalColumn: "QytetiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_restaurant_Qyteti_Restauranti_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restauranti",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_restaurant_Qyteti_RestaurantID",
                table: "restaurant_Qyteti",
                column: "RestaurantID");
        }
    }
}
