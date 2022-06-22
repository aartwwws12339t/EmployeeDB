using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWorkApp.Migrations
{
    public partial class Tweak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Ammount",
                table: "PositionSalarys",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Ammount",
                table: "PositionSalarys",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
