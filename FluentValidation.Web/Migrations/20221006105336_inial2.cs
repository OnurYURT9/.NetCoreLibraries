using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidation.Web.Migrations
{
    public partial class inial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Brithday",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brithday",
                table: "Customers");
        }
    }
}
