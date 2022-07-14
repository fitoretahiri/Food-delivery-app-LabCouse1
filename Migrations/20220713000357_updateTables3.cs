using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updateTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nr_tel",
                table: "Telefoni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Telefoni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefoni_RestaurantId",
                table: "Telefoni",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefoni_Restauranti_RestaurantId",
                table: "Telefoni",
                column: "RestaurantId",
                principalTable: "Restauranti",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefoni_Restauranti_RestaurantId",
                table: "Telefoni");

            migrationBuilder.DropIndex(
                name: "IX_Telefoni_RestaurantId",
                table: "Telefoni");

            migrationBuilder.DropColumn(
                name: "Nr_tel",
                table: "Telefoni");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Telefoni");
        }
    }
}
