using Microsoft.EntityFrameworkCore.Migrations;

namespace SVL.Infra.Migrations
{
    public partial class LocationStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationStatus",
                table: "Location",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationStatus",
                table: "Location");
        }
    }
}
