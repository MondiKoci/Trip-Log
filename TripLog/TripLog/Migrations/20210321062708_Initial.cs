using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accomodation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingsToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingsToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingsToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodation", "AccomodationEmail", "AccomodationPhone", "Destination", "EndDate", "StartDate", "ThingsToDo1", "ThingsToDo2", "ThingsToDo3" },
                values: new object[] { 1, "Hotel Blitz", "Bliz@blitz.blitz", "123-123-1234", "Honolulu", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Check the Feifel Tower", null, null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodation", "AccomodationEmail", "AccomodationPhone", "Destination", "EndDate", "StartDate", "ThingsToDo1", "ThingsToDo2", "ThingsToDo3" },
                values: new object[] { 2, "Hotel Bungalo", "Bungalo@Bungalo.com", "333-333-4444", "Las Vegas", new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visit the desert", "Sleep as much as you can", "Play black jack" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
