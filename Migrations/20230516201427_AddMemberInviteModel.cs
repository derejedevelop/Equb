using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equb.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberInviteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberInvites",
                columns: table => new
                {
                    MemberInviteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EqubId = table.Column<int>(type: "INTEGER", nullable: true),
                    InviterUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    InviteeUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    Accepted = table.Column<bool>(type: "INTEGER", nullable: true),
                    Declined = table.Column<bool>(type: "INTEGER", nullable: true),
                    InviteDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReplyDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberInvites", x => x.MemberInviteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberInvites");
        }
    }
}
