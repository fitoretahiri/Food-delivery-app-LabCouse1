using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "restaurant_Qyteti",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    restaurantID = table.Column<int>(type: "int", nullable: false),
                    qytetiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant_Qyteti", x => x.id);
                    table.ForeignKey(
                        name: "FK_restaurant_Qyteti_Qyteti_qytetiID",
                        column: x => x.qytetiID,
                        principalTable: "Qyteti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_restaurant_Qyteti_Restaurant_restaurantID",
                        column: x => x.restaurantID,
                        principalTable: "Restaurant",
                        principalColumn: "restaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Qyteti_qytetiID",
                table: "restaurant_Qyteti",
                column: "qytetiID");

            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Qyteti_restaurantID",
                table: "restaurant_Qyteti",
                column: "restaurantID");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurant_restaurantID",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                table: "Transportuesi");

            migrationBuilder.DropTable(
                name: "restaurant_Qyteti");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Menu_restaurantID",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "restaurantID",
                table: "Menu");

            migrationBuilder.AlterColumn<int>(
                name: "perdoruesiID",
                table: "Transportuesi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Restoranti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_regjistrimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nr_kontaktues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qyteti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restoranti", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                table: "Transportuesi",
                column: "perdoruesiID",
                principalTable: "Perdoruesi",
                principalColumn: "perdoruesiID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
