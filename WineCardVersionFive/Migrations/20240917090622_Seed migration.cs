using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardVersionFive.Migrations
{
    /// <inheritdoc />
    public partial class Seedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WineCards",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$U7DFbHtdyCsSHcU1cpQOFuoSUnj7eJbNebEg9V4LqZqmucQXo.mN.");

            migrationBuilder.InsertData(
                table: "WineCards",
                columns: new[] { "WineCardId", "Name" },
                values: new object[] { 1, "Unsere Weinkarte" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WineCards",
                keyColumn: "WineCardId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WineCards");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$3ZYFAmKuYezdd7hTnyGnHedcmDQOlDjss6B8wBd3.TLwGFjvsgce2");
        }
    }
}
