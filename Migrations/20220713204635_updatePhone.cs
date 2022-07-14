using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updatePhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefoni_Restauranti_RestaurantId",
                table: "Telefoni");

            migrationBuilder.DropIndex(
                name: "IX_Telefoni_RestaurantId",
                table: "Telefoni");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
