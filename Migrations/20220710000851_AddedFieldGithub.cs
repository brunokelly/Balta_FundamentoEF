using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    public partial class AddedFieldGithub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 0, 8, 51, 182, DateTimeKind.Utc).AddTicks(1111),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2022, 7, 10, 0, 0, 46, 353, DateTimeKind.Utc).AddTicks(3908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2022, 7, 10, 0, 0, 46, 353, DateTimeKind.Utc).AddTicks(3908),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2022, 7, 10, 0, 8, 51, 182, DateTimeKind.Utc).AddTicks(1111));
        }
    }
}
