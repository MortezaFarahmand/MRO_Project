using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationManagement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_Organization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NameFa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DescriptionFa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AddressEn = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    AddressFa = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    Tel1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SocialAddress1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SocialAddress2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MailBox = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    OrganizationAviationCodeId = table.Column<long>(type: "bigint", maxLength: 255, nullable: false),
                    CompanyRegisterNo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FormedDate = table.Column<DateTime>(type: "datetime2", maxLength: 150, nullable: false),
                    ParentId = table.Column<long>(type: "bigint", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", maxLength: 255, nullable: false),
                    LogoPicture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoPictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LogoPictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CanonicalAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrganizationGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_OrganizationGroups_OrganizationGroupId",
                        column: x => x.OrganizationGroupId,
                        principalTable: "OrganizationGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrganizationGroupId",
                table: "Organizations",
                column: "OrganizationGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
