using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class dropTableLagje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qyteti_Lagje_LagjeId",
                table: "Qyteti");

            migrationBuilder.DropTable(
                name: "Lagje");

            migrationBuilder.DropIndex(
                name: "IX_Qyteti_LagjeId",
                table: "Qyteti");

            migrationBuilder.DropColumn(
                name: "LagjeId",
                table: "Qyteti");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LagjeId",
                table: "Qyteti",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Qyteti_LagjeId",
                table: "Qyteti",
                column: "LagjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qyteti_Lagje_LagjeId",
                table: "Qyteti",
                column: "LagjeId",
                principalTable: "Lagje",
                principalColumn: "LagjeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
