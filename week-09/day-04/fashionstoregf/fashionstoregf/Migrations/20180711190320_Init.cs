using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fashionstoregf.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "warehouse",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    manufacturer = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    category = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    size = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    unit_price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "warehouse");
        }
    }
}
