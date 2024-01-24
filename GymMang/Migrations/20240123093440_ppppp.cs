using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMang.Migrations
{
    public partial class ppppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GymTraineeDetailViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gymTraineeTraineeId = table.Column<int>(type: "int", nullable: false),
                    TrainingLevelID = table.Column<int>(type: "int", nullable: false),
                    MonthlyFeeVoucherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymTraineeDetailViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymTraineeDetailViewModel_MonthlyFeeVouchers_MonthlyFeeVoucherID",
                        column: x => x.MonthlyFeeVoucherID,
                        principalTable: "MonthlyFeeVouchers",
                        principalColumn: "MonthlyFeeVoucherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymTraineeDetailViewModel_Trainees_gymTraineeTraineeId",
                        column: x => x.gymTraineeTraineeId,
                        principalTable: "Trainees",
                        principalColumn: "TraineeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymTraineeDetailViewModel_TrainingLevels_TrainingLevelID",
                        column: x => x.TrainingLevelID,
                        principalTable: "TrainingLevels",
                        principalColumn: "TrainingLevelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymTraineeDetailViewModel_gymTraineeTraineeId",
                table: "GymTraineeDetailViewModel",
                column: "gymTraineeTraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_GymTraineeDetailViewModel_MonthlyFeeVoucherID",
                table: "GymTraineeDetailViewModel",
                column: "MonthlyFeeVoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_GymTraineeDetailViewModel_TrainingLevelID",
                table: "GymTraineeDetailViewModel",
                column: "TrainingLevelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymTraineeDetailViewModel");
        }
    }
}
