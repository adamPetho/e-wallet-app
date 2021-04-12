using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Wallet_Alpha.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Balance = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransictionTable",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    ToWhom = table.Column<string>(type: "text", nullable: true),
                    AmountOfMoney = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransictionTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransictionTable_UserTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransictionTable_UserID",
                table: "TransictionTable",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransictionTable");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
