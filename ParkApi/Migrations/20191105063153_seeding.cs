using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkApi.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Corrdinates",
                table: "Parks");

            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "Parks",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Attraction", "Coordinates", "Information", "Location", "ParkName", "RequirmentType" },
                values: new object[,]
                {
                    { 1, "Hiking, Lava Rock, Waterfall, Draw Bridge", "46.1654, -122.0890", "This hike has three sections. The first being very friendly, the second a little adventurest and the third for the experienced no fear of heights hikers. Ether way you will enjoy the one of the many beautiful views of what this powerful mountain has to offer.", "South Cascases, Mount St. Helens", "Lava Canyon", "Parking Pass with Northwest Forest Pass, $5 fee at site. No dogs." },
                    { 2, "Nice short hike surrounded in western redcedar, hemlock and fir trees.", "45.7556, -122.5111", "1.8 miles, Good for kids.", "SouthWest Washington", "Salmon-Morgan Creeks Natrual Area", "No parking pass or fee required. Dogs are allowed on trail." },
                    { 3, "Lots of space for family events. Covered pinic areas, play structures for childern, volleyball nets, softball field and a river for cooling off.", "45.8190, -122.5452", "Good for familys, pets,wildlife, fall foilage, and old growth trees", "SouthWest Washington, Lewis River Region", "Lewisville Regional Park", "Parking Fee required: $2 for motorcycles, 3 for cars, $6 for cars with trailers and $8 for buses or motor homes" },
                    { 4, "Waterfalls, Short 1.1 mile hike round trip with a 20 foot elevation gain.", "45.8407, -122.4470", "Family and pet friendly, waterfalls and rivers", "SouthWest Washington", "Lucia Falls", "No parking pass or fee required" },
                    { 5, "Waterfalls, river side.", "45.9406, -122.2294", "13.8 mile hike with 635 ft gain in elevation", "Southwest Washington ", "Siouxon Creek", "Northwest Forest Pass" },
                    { 6, "Waterfalls, Rivers, Footbridge, dogs allowed, summit views", "45.9430, -122.1854", "15.3 mile hike with  5120 ft elevation gain", "South Cascades", "Siouxon Peak Loop", "Northwest Forest Pass" },
                    { 7, "Stressfree hike with beutiful ending to a river and waterfall.", "46.1373, -122.1569", "No dogs allowed, waterfall, family friendly, mountain views", "South Cascades", "June Lake", "NorthWest Forest Pass" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "Parks");

            migrationBuilder.AddColumn<int>(
                name: "Corrdinates",
                table: "Parks",
                nullable: false,
                defaultValue: 0);
        }
    }
}
