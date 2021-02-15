using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Wallet_Alpha.Migrations
{
    public partial class RenameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransictionTable_UserTable_UserID",
                table: "TransictionTable");

            migrationBuilder.RenameColumn(
                name: "ToOrFromSomeOne",
                table: "TransictionTable",
                newName: "Receiver");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "TransictionTable",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TransictionTable",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_TransictionTable_UserTable_UserID",
                table: "TransictionTable",
                column: "UserID",
                principalTable: "UserTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransictionTable_UserTable_UserID",
                table: "TransictionTable");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "TransictionTable");

            migrationBuilder.RenameColumn(
                name: "Receiver",
                table: "TransictionTable",
                newName: "ToOrFromSomeOne");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "TransictionTable",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_TransictionTable_UserTable_UserID",
                table: "TransictionTable",
                column: "UserID",
                principalTable: "UserTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
