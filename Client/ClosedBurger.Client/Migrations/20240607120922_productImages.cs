using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClosedBurger.Client.Migrations
{
    /// <inheritdoc />
    public partial class productImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Product");
        }
    }
}
