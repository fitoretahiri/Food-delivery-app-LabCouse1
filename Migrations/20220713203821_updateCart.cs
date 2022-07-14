using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updateCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Porosia_PorosiaId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_PorosiaId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "PorosiaId",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Porosia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Porosia_CartId",
                table: "Porosia",
                column: "CartId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Porosia_Cart_CartId",
                table: "Porosia",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Porosia_Cart_CartId",
                table: "Porosia");

            migrationBuilder.DropIndex(
                name: "IX_Porosia_CartId",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Porosia");

            migrationBuilder.AddColumn<int>(
                name: "PorosiaId",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_PorosiaId",
                table: "Cart",
                column: "PorosiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Porosia_PorosiaId",
                table: "Cart",
                column: "PorosiaId",
                principalTable: "Porosia",
                principalColumn: "PorosiaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
