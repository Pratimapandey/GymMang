using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.RenameColumn(
                name: "gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                newName: "TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_GymTraineeDetailViewModel_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                newName: "IX_GymTraineeDetailViewModel_TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
                table: "GymTraineeDetailViewModel",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.RenameColumn(
                name: "TraineeId",
                table: "GymTraineeDetailViewModel",
                newName: "gymTraineeTraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_GymTraineeDetailViewModel_TraineeId",
                table: "GymTraineeDetailViewModel",
                newName: "IX_GymTraineeDetailViewModel_gymTraineeTraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                column: "gymTraineeTraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
