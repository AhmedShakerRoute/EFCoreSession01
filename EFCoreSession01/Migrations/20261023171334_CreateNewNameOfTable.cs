using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSession01.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewNameOfTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "HamadaProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HamadaProducts",
                table: "HamadaProducts",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HamadaProducts",
                table: "HamadaProducts");

            migrationBuilder.RenameTable(
                name: "HamadaProducts",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
