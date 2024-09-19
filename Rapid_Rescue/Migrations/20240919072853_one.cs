using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rapid_Rescue.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ambulances",
                columns: table => new
                {
                    ambulancesid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicle_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipment_level = table.Column<int>(type: "int", nullable: false),
                    current_stastus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ambulances", x => x.ambulancesid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ambulances");
        }
    }
}
