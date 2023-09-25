using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "Id", "QestionText" },
                values: new object[,]
                {
                    { 1, "En sevdiğiniz yemek nedir?" },
                    { 2, "İlk evcil hayvanınızın adı nedir?" },
                    { 3, "En sevdiğiniz spor nedir?" },
                    { 4, "Hangi şehirde doğdunuz?" },
                    { 5, "En sevdiğiniz çocukluk arkadaşınızın adı nedir?" },
                    { 6, "Hangi okulda ilk kez öğrenim gördünüz?" },
                    { 7, "En sevdiğiniz hayvan nedir?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
