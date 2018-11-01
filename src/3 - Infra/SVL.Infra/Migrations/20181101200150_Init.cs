using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SVL.Infra.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    StreetDescription = table.Column<string>(type: "varchar(150)", nullable: false),
                    District = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Credit",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    CreditPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Devolution",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    IsFinished = table.Column<bool>(nullable: false),
                    DevolutionStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolution", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    LocationStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsRelease = table.Column<bool>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    Genero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaLocation",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    LocationID1 = table.Column<Guid>(nullable: true),
                    MediaID = table.Column<int>(type: "int", nullable: false),
                    MediaID1 = table.Column<Guid>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    IsRewound = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaLocation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MediaLocation_Location_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaLocation_Media_MediaID1",
                        column: x => x.MediaID1,
                        principalTable: "Media",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomerId",
                table: "Contact",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaLocation_LocationID1",
                table: "MediaLocation",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_MediaLocation_MediaID1",
                table: "MediaLocation",
                column: "MediaID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Credit");

            migrationBuilder.DropTable(
                name: "Devolution");

            migrationBuilder.DropTable(
                name: "MediaLocation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Media");
        }
    }
}
