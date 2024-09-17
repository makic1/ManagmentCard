using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardVersionFive.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.AlterColumn<int>(
                name: "WineCardId",
                table: "Wines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$3ZYFAmKuYezdd7hTnyGnHedcmDQOlDjss6B8wBd3.TLwGFjvsgce2");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.AlterColumn<int>(
                name: "WineCardId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$QfGmS7EoeB.O3GaW/LH2d.n5FT94EOvZwxAlgBDQmKKt1cV3KPLoq");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
