using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddit.Migrations
{
    public partial class addDateOfPostToThModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateOfPost",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfPost",
                table: "Posts");
        }
    }
}
