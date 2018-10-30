using Microsoft.EntityFrameworkCore.Migrations;

namespace SVL.Infra.Migrations
{
    public partial class AjusteMidia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Devolution_DevolutionID",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Location_LocationAggregateID",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_DevolutionID",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_LocationAggregateID",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "DevolutionID",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "LocationAggregateID",
                table: "Media");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DevolutionID",
                table: "Media",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationAggregateID",
                table: "Media",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Media_DevolutionID",
                table: "Media",
                column: "DevolutionID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_LocationAggregateID",
                table: "Media",
                column: "LocationAggregateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Devolution_DevolutionID",
                table: "Media",
                column: "DevolutionID",
                principalTable: "Devolution",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Location_LocationAggregateID",
                table: "Media",
                column: "LocationAggregateID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
