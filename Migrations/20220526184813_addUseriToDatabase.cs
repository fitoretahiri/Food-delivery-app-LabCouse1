using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class addUseriToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Useri",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photoProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    confirmPsw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roliID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Useri", x => x.userID);
                    table.ForeignKey(
                        name: "FK_Useri_Roli_roliID",
                        column: x => x.roliID,
                        principalTable: "Roli",
                        principalColumn: "roliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Useri_roliID",
                table: "Useri",
                column: "roliID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Useri");
        }
    }
}
