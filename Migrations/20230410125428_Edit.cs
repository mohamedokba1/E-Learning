﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Learning.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "User_id",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students",
                column: "User_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "User_id",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_User_id",
                table: "Students",
                column: "User_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
