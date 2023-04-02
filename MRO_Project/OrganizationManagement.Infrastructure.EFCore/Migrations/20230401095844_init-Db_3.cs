﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationManagement.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class initDb_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "OrganizationGroups");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "OrganizationGroups");

            migrationBuilder.DropColumn(
                name: "PictureAlt",
                table: "OrganizationGroups");

            migrationBuilder.DropColumn(
                name: "PictureTitle",
                table: "OrganizationGroups");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "OrganizationGroups");

            migrationBuilder.AddColumn<string>(
                name: "NameCode",
                table: "OrganizationGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameCode",
                table: "OrganizationGroups");

            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "OrganizationGroups",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "OrganizationGroups",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PictureAlt",
                table: "OrganizationGroups",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PictureTitle",
                table: "OrganizationGroups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "OrganizationGroups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
