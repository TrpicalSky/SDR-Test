using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDR_Test.Data.Migrations
{
    /// <inheritdoc />
    public partial class beabletostorepdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Invoice",
                table: "Job",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Invoice",
                table: "Job");
        }
    }
}
