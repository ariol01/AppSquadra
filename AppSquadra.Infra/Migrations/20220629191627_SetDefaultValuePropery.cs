using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppSquadra.Infra.Migrations
{
    public partial class SetDefaultValuePropery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartaoLeads",
                table: "CartaoLeads");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "CartaoLeads");

            migrationBuilder.RenameTable(
                name: "CartaoLeads",
                newName: "CartaoLead");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "CartaoLead",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "CartaoLead",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "CartaoLead",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CartaoLead",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "CartaoLead",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartaoLead",
                table: "CartaoLead",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartaoLead",
                table: "CartaoLead");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CartaoLead");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CartaoLead");

            migrationBuilder.RenameTable(
                name: "CartaoLead",
                newName: "CartaoLeads");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "CartaoLeads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "CartaoLeads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "CartaoLeads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsAccepted",
                table: "CartaoLeads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartaoLeads",
                table: "CartaoLeads",
                column: "Id");
        }
    }
}
