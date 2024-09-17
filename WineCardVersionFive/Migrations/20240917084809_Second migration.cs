using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardVersionFive.Migrations
{
    /// <inheritdoc />
    public partial class Secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$QfGmS7EoeB.O3GaW/LH2d.n5FT94EOvZwxAlgBDQmKKt1cV3KPLoq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$0ysTp1/cVzD0EjQua8t5oeU2V2Z5KDZsZPldacCCfchDEvXv9wHQ2");
        }
    }
}
