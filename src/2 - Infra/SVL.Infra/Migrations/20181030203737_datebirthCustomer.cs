using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVL.Infra.Migrations
{
    public partial class datebirthCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBirth",
                table: "Customer",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBirth",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
