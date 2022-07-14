using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_delivery_app_LabCouse1.Migrations
{
    public partial class updateTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestFavorite",
                columns: table => new
                {
                    FavID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestFavorite", x => x.FavID);
                    table.ForeignKey(
                        name: "FK_RestFavorite_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestFavorite_Restauranti_RestId",
                        column: x => x.RestId,
                        principalTable: "Restauranti",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefoni",
                columns: table => new
                {
                    Numri = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefoni", x => x.Numri);
                    table.ForeignKey(
                        name: "FK_Telefoni_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vleresimet",
                columns: table => new
                {
                    VlersimiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vleresimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vleresimet", x => x.VlersimiID);
                    table.ForeignKey(
                        name: "FK_Vleresimet_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestFavorite_RestId",
                table: "RestFavorite",
                column: "RestId");

            migrationBuilder.CreateIndex(
                name: "IX_RestFavorite_UserId",
                table: "RestFavorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefoni_UserId",
                table: "Telefoni",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vleresimet_MenuID",
                table: "Vleresimet",
                column: "MenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestFavorite");

            migrationBuilder.DropTable(
                name: "Telefoni");

            migrationBuilder.DropTable(
                name: "Vleresimet");
        }
    }
}
