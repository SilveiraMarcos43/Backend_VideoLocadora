using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVL.Infra.Migrations
{
    public partial class AjusteDataMidia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Media",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Media",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATEONLY");
        }
    }
}
