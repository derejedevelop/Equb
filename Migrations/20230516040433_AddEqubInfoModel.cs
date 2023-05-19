using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equb.Migrations
{
    /// <inheritdoc />
    public partial class AddEqubInfoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EqubInfo",
                columns: table => new
                {
                    EqubInfoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EqubName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminId = table.Column<int>(type: "INTEGER", nullable: true),
                    FrequencyDays = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqubInfo", x => x.EqubInfoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EqubInfo");
        }
    }
}
