using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guilherme_Freitas.Migrations
{
    /// <inheritdoc />
    public partial class folha_full : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImpostoFgts",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImpostoInss",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImpostoIrrf",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalarioBruto",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalarioLiquido",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoIrrf",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "Folhas");
        }
    }
}
