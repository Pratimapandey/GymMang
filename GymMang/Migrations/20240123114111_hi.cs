using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class hi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel",
                column: "MonthlyFeeVoucherID",
                principalTable: "MonthlyFeeVouchers",
                principalColumn: "MonthlyFeeVoucherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                column: "gymTraineeTraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel",
                column: "MonthlyFeeVoucherID",
                principalTable: "MonthlyFeeVouchers",
                principalColumn: "MonthlyFeeVoucherID");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                column: "gymTraineeTraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID");
        }
    }
}
