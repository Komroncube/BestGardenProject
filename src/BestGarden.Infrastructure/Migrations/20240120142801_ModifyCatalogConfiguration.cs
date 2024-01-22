using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestGarden.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCatalogConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 14, 27, 59, 718, DateTimeKind.Utc).AddTicks(8332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 1, 20, 14, 13, 54, 538, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.AlterColumn<string>(
                name: "PlantSystem",
                table: "Catalogs",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 14, 13, 54, 538, DateTimeKind.Utc).AddTicks(3684),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 1, 20, 14, 27, 59, 718, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.AlterColumn<string>(
                name: "PlantSystem",
                table: "Catalogs",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);
        }
    }
}
