using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandartPortion = table.Column<double>(type: "float", nullable: false),
                    PortionProtein = table.Column<double>(type: "float", nullable: false),
                    PortionFat = table.Column<double>(type: "float", nullable: false),
                    PortionCarb = table.Column<double>(type: "float", nullable: false),
                    PortionCalorie = table.Column<double>(type: "float", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QestionText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionAnswer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityQuestionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_SecurityQuestions_SecurityQuestionId",
                        column: x => x.SecurityQuestionId,
                        principalTable: "SecurityQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumedFoods",
                columns: table => new
                {
                    ConsumedFoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portion = table.Column<double>(type: "float", nullable: false),
                    ConsumedCount = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealCategory = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumedFoods", x => x.ConsumedFoodId);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumedWaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Portion = table.Column<double>(type: "float", nullable: false),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumedWaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumedWaters_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaPosts",
                columns: table => new
                {
                    SocialMediaPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PostDescription = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaPosts", x => x.SocialMediaPostId);
                    table.ForeignKey(
                        name: "FK_SocialMediaPosts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    LastWeight = table.Column<double>(type: "float", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    ExerciseLevel = table.Column<double>(type: "float", nullable: false),
                    TargetWeight = table.Column<double>(type: "float", nullable: false),
                    TargetWaterIntake = table.Column<double>(type: "float", nullable: false),
                    TargetCalorieIntake = table.Column<double>(type: "float", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_UserDetails_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightHistories",
                columns: table => new
                {
                    WeightHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WeightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightHistories", x => x.WeightHistoryId);
                    table.ForeignKey(
                        name: "FK_WeightHistories_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikedAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedAccounts_SocialMediaPosts_SocialMediaPostId",
                        column: x => x.SocialMediaPostId,
                        principalTable: "SocialMediaPosts",
                        principalColumn: "SocialMediaPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SecurityQuestionId",
                table: "Accounts",
                column: "SecurityQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_AccountID",
                table: "ConsumedFoods",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_FoodID",
                table: "ConsumedFoods",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedWaters_AccountID",
                table: "ConsumedWaters",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_LikedAccounts_SocialMediaPostId",
                table: "LikedAccounts",
                column: "SocialMediaPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaPosts_AccountId",
                table: "SocialMediaPosts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightHistories_AccountID",
                table: "WeightHistories",
                column: "AccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumedFoods");

            migrationBuilder.DropTable(
                name: "ConsumedWaters");

            migrationBuilder.DropTable(
                name: "LikedAccounts");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "WeightHistories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "SocialMediaPosts");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "SecurityQuestions");
        }
    }
}
