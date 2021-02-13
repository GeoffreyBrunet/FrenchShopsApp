using Microsoft.EntityFrameworkCore.Migrations;

namespace FrenchShopsApp.Migrations
{
    public partial class addT_ShopDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomShop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressShop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlShop = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Shop", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Shop");
        }
    }
}
