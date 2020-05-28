using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeCookersAuthAPI.Migrations
{
    public partial class IniticalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tales_of_runeterra");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "tales_of_runeterra",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AllowedFlag = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "tales_of_runeterra");
        }
    }
}
