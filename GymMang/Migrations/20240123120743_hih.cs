using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class hih : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingLevelID1",
                table: "GymTraineeDetailViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GymTraineeDetailViewModel_TrainingLevelID1",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID1");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID1",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID1",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID1",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropIndex(
                name: "IX_GymTraineeDetailViewModel_TrainingLevelID1",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropColumn(
                name: "TrainingLevelID1",
                table: "GymTraineeDetailViewModel");
        }
    }
}
