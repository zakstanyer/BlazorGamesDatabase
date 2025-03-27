﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppGames.Migrations
{
    /// <inheritdoc />
    public partial class AddScoreField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Score",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "N/A");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Game");
        }
    }
}
