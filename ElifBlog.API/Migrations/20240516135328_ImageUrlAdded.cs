﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElifBlog.API.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrlAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BlogTable",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BlogTable");
        }
    }
}
