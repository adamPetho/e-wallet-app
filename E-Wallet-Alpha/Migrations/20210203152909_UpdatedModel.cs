using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Wallet_Alpha.Migrations
{
    public partial class UpdatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToWhom",
                table: "TransictionTable",
                newName: "ToOrFromSomeOne");

            migrationBuilder.AddColumn<bool>(
                name: "DidIGetMoney",
                table: "TransictionTable",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DidIGetMoney",
                table: "TransictionTable");

            migrationBuilder.RenameColumn(
                name: "ToOrFromSomeOne",
                table: "TransictionTable",
                newName: "ToWhom");
        }
    }
}
