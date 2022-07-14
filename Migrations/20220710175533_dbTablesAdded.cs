using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class dbTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subjekti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesazhi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lagje",
                columns: table => new
                {
                    LagjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lagje", x => x.LagjeId);
                });

            migrationBuilder.CreateTable(
                name: "Porosia",
                columns: table => new
                {
                    PorosiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CartID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porosia", x => x.PorosiaId);
                    table.ForeignKey(
                        name: "FK_Porosia_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Porosia_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qyteti",
                columns: table => new
                {
                    QytetiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LagjeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qyteti", x => x.QytetiID);
                    table.ForeignKey(
                        name: "FK_Qyteti_Lagje_LagjeId",
                        column: x => x.LagjeId,
                        principalTable: "Lagje",
                        principalColumn: "LagjeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restauranti",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_regjistrimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NrYjeve = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emertimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmimi = table.Column<double>(type: "float", nullable: false),
                    Nr_artikujve = table.Column<int>(type: "int", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    PijaID = table.Column<int>(type: "int", nullable: false),
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
                name: "CartItemMenu",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItemMenu", x => new { x.CartID, x.MenuID });
                    table.ForeignKey(
                        name: "FK_CartItemMenu_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItemMenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartMenu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    SavedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartMenu", x => new { x.MenuID, x.CartID });
                    table.ForeignKey(
                        name: "FK_CartMenu_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartMenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItemMenu_MenuID",
                table: "CartItemMenu",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_CartMenu_CartID",
                table: "CartMenu",
                column: "CartID");

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
                name: "IX_Porosia_CartID",
                table: "Porosia",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_Porosia_UserId",
                table: "Porosia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qyteti_LagjeId",
                table: "Qyteti",
                column: "LagjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Restauranti_QytetiID",
                table: "Restauranti",
                column: "QytetiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItemMenu");

            migrationBuilder.DropTable(
                name: "CartMenu");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "Porosia");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Restauranti");

            migrationBuilder.DropTable(
                name: "Qyteti");

            migrationBuilder.DropTable(
                name: "Lagje");
        }
    }
}
