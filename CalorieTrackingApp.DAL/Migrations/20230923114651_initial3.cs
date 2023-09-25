using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "MealType", "Name", "Photo", "PortionCalorie", "PortionCarb", "PortionFat", "PortionProtein", "StandartPortion" },
                values: new object[,]
                {
                    { 1, 2, "Köfte", null, 300.0, 5.0, 15.0, 25.0, 100.0 },
                    { 2, 9, "Pilav", null, 250.0, 50.0, 10.0, 5.0, 100.0 },
                    { 3, 1, "Salata", null, 70.0, 10.0, 5.0, 2.0, 100.0 },
                    { 4, 4, "Balık", null, 200.0, 0.0, 10.0, 20.0, 100.0 },
                    { 5, 10, "Pasta", null, 350.0, 40.0, 15.0, 10.0, 100.0 },
                    { 6, 7, "Çorba", null, 120.0, 15.0, 5.0, 5.0, 100.0 },
                    { 7, 0, "Elma", null, 52.0, 13.0, 0.20000000000000001, 0.5, 100.0 },
                    { 8, 0, "Muz", null, 105.0, 27.0, 0.29999999999999999, 1.1000000000000001, 100.0 },
                    { 9, 3, "Tavuk", null, 165.0, 0.0, 3.6000000000000001, 32.0, 100.0 },
                    { 10, 4, "Somon", null, 206.0, 0.0, 13.0, 20.0, 100.0 },
                    { 11, 1, "Karnabahar", null, 25.0, 5.0, 0.5, 2.0, 100.0 },
                    { 12, 2, "Tavuk Kebabı", null, 176.0, 0.5, 4.0999999999999996, 32.0, 100.0 },
                    { 13, 11, "Makarna", null, 371.0, 71.0, 1.3, 12.0, 100.0 },
                    { 14, 5, "Baklava", null, 509.0, 65.0, 40.0, 5.4000000000000004, 100.0 },
                    { 15, 5, "Çikolata", null, 546.0, 60.0, 29.0, 5.5, 100.0 },
                    { 16, 6, "Yumurta", null, 155.0, 1.1000000000000001, 11.0, 13.0, 100.0 },
                    { 17, 6, "Cips", null, 536.0, 49.0, 37.0, 6.7000000000000002, 100.0 },
                    { 18, 1, "Brokoli", null, 55.0, 11.0, 0.59999999999999998, 2.7999999999999998, 100.0 },
                    { 19, 0, "Portakal", null, 43.0, 8.3000000000000007, 0.20000000000000001, 1.0, 100.0 },
                    { 20, 3, "Hindi", null, 135.0, 0.0, 1.5, 29.0, 100.0 },
                    { 21, 4, "Karides", null, 85.0, 0.0, 0.90000000000000002, 20.0, 100.0 },
                    { 22, 2, "Sote", null, 280.0, 4.0, 13.0, 27.0, 100.0 },
                    { 23, 11, "Pizza", null, 266.0, 32.0, 11.0, 12.0, 100.0 },
                    { 24, 5, "Puding", null, 127.0, 22.0, 3.6000000000000001, 2.7000000000000002, 100.0 },
                    { 25, 8, "Kola", null, 45.0, 11.0, 0.0, 0.0, 100.0 },
                    { 26, 8, "Çay", null, 1.0, 0.0, 0.0, 0.10000000000000001, 100.0 },
                    { 27, 0, "Meyve Salatası", null, 56.0, 14.0, 0.10000000000000001, 0.90000000000000002, 100.0 },
                    { 28, 1, "Pancar Salatası", null, 43.0, 9.5999999999999996, 0.20000000000000001, 1.6000000000000001, 100.0 },
                    { 29, 3, "Fırın Tavuk", null, 135.0, 0.0, 3.6000000000000001, 23.0, 100.0 },
                    { 30, 4, "Levrek", null, 167.0, 0.0, 9.0, 20.0, 100.0 },
                    { 31, 1, "Mantar Sote", null, 36.0, 4.9000000000000004, 1.8, 3.1000000000000001, 100.0 },
                    { 32, 0, "Mango", null, 60.0, 14.0, 0.59999999999999998, 0.80000000000000004, 100.0 },
                    { 33, 2, "Kuzu Şiş", null, 151.0, 0.0, 5.0, 25.0, 100.0 },
                    { 34, 1, "Roka Salatası", null, 19.0, 2.2000000000000002, 0.29999999999999999, 2.8999999999999999, 100.0 },
                    { 35, 3, "Tavuk Salatası", null, 188.0, 3.0, 6.0, 28.0, 100.0 },
                    { 36, 4, "Karides Güveç", null, 125.0, 5.0, 5.0, 15.0, 100.0 },
                    { 37, 2, "Kuzu Tandır", null, 325.0, 0.0, 19.0, 32.0, 100.0 },
                    { 38, 11, "Pasta Salatası", null, 160.0, 21.0, 8.0, 2.7999999999999998, 100.0 },
                    { 39, 5, "Cheesecake", null, 321.0, 19.0, 26.0, 6.0, 100.0 },
                    { 40, 6, "Kumpir", null, 242.0, 33.0, 12.0, 5.7000000000000002, 100.0 },
                    { 41, 2, "Karnıyarık", null, 224.0, 16.0, 16.0, 5.4000000000000004, 100.0 },
                    { 42, 1, "Kısır", null, 130.0, 21.0, 2.0, 5.0, 100.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "MealType", "Name", "Photo", "PortionCalorie", "PortionCarb", "PortionFat", "PortionProtein", "StandartPortion" },
                values: new object[] { 43, 5, "Dondurma", null, 178.0, 20.0, 7.2999999999999998, 3.6000000000000001, 100.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "MealType", "Name", "Photo", "PortionCalorie", "PortionCarb", "PortionFat", "PortionProtein", "StandartPortion" },
                values: new object[] { 44, 8, "Soda", null, 45.0, 11.0, 0.0, 0.0, 100.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "MealType", "Name", "Photo", "PortionCalorie", "PortionCarb", "PortionFat", "PortionProtein", "StandartPortion" },
                values: new object[] { 45, 8, "Su", null, 0.0, 0.0, 0.0, 0.0, 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45);
        }
    }
}
