﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidation.Web.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Customers",
                  nullable: false,
                  defaultValue: 0
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
