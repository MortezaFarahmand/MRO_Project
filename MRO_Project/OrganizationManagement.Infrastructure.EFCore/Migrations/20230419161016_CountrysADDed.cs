using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationManagement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CountrysADDed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Alpha2Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Alpha3Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UNCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DialCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TailCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
