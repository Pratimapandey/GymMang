using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class hellooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
                table: "GymTraineeDetailViewModel",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
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
                name: "FK_GymTraineeDetailViewModel_Trainees_TraineeId",
                table: "GymTraineeDetailViewModel",
                column: "TraineeId",
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
    }
}
