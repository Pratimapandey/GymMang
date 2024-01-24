using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class hiiiii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_Trainees_TraineeId",
                table: "GymTraineeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetails",
                column: "MonthlyFeeVoucherID",
                principalTable: "MonthlyFeeVouchers",
                principalColumn: "MonthlyFeeVoucherID");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_Trainees_TraineeId",
                table: "GymTraineeDetails",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetails",
                column: "TrainingLevelID",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_Trainees_TraineeId",
                table: "GymTraineeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTraineeDetails_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                table: "GymTraineeDetails",
                column: "MonthlyFeeVoucherID",
                principalTable: "MonthlyFeeVouchers",
                principalColumn: "MonthlyFeeVoucherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_Trainees_TraineeId",
                table: "GymTraineeDetails",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "TraineeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTraineeDetails_TrainingLevels_TrainingLevelID",
                table: "GymTraineeDetails",
                column: "TrainingLevelID",
                principalTable: "TrainingLevels",
                principalColumn: "TrainingLevelID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
