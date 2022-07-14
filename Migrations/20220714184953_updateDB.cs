using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagesa");

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Porosia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormaPageses",
                table: "Porosia",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Porosia");

            migrationBuilder.DropColumn(
                name: "FormaPageses",
                table: "Porosia");

            migrationBuilder.CreateTable(
                name: "Pagesa",
                columns: table => new
                {
                    PagesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorosiaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagesa", x => x.PagesaId);
                    table.ForeignKey(
                        name: "FK_Pagesa_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagesa_Porosia_PorosiaId",
                        column: x => x.PorosiaId,
                        principalTable: "Porosia",
                        principalColumn: "PorosiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagesa_PorosiaId",
                table: "Pagesa",
                column: "PorosiaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagesa_UserId",
                table: "Pagesa",
                column: "UserId");
        }
    }
}
