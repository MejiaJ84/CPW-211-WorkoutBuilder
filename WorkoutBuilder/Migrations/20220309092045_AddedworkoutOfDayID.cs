using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutBuilder.Migrations
{
    public partial class AddedworkoutOfDayID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutOfDays",
                table: "WorkoutOfDays");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutOfDayID",
                table: "WorkoutOfDays",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutOfDays",
                table: "WorkoutOfDays",
                column: "WorkoutOfDayID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutOfDays_WorkoutID",
                table: "WorkoutOfDays",
                column: "WorkoutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutOfDays",
                table: "WorkoutOfDays");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutOfDays_WorkoutID",
                table: "WorkoutOfDays");

            migrationBuilder.DropColumn(
                name: "WorkoutOfDayID",
                table: "WorkoutOfDays");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutOfDays",
                table: "WorkoutOfDays",
                column: "WorkoutID");
        }
    }
}
