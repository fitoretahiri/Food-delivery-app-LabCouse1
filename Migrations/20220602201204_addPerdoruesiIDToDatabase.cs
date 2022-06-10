using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class addPerdoruesiIDToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                table: "Transportuesi");

            migrationBuilder.AlterColumn<int>(
                name: "perdoruesiID",
                table: "Transportuesi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                table: "Transportuesi",
                column: "perdoruesiID",
                principalTable: "Perdoruesi",
                principalColumn: "perdoruesiID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transportuesi_Perdoruesi_perdoruesiID",
                table: "Transportuesi");

            migrationBuilder.AlterColumn<int>(
                name: "perdoruesiID",
                table: "Transportuesi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
