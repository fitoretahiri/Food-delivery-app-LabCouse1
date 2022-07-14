using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updatePorosia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Porosia_Cart_CartId",
                table: "Porosia");

            migrationBuilder.DropIndex(
                name: "IX_Porosia_CartId",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "Statusi",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "CmimiTotal",
                table: "Pagesa");

            migrationBuilder.AddColumn<double>(
                name: "CmimiTotal",
                table: "Porosia",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CmimiTotal",
                table: "Porosia");

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Porosia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Porosia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Statusi",
                table: "Porosia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CmimiTotal",
                table: "Pagesa",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
    }
}
