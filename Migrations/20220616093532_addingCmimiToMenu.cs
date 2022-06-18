using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class addingCmimiToMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cmimi",
                table: "Menu",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cmimi",
                table: "Menu");
        }
    }
}
