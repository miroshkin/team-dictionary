using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace teamdictionary.Migrations
{
    public partial class DeletedTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Translation",
                table: "Articles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Translation",
                table: "Articles",
                nullable: true);
        }
    }
}
