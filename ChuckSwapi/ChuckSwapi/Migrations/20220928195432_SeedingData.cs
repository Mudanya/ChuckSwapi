using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChuckSwapi.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mass",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkinColor",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "animal" },
                    { 2, "career" },
                    { 3, "celebrity" },
                    { 4, "explicit" },
                    { 5, "fashion" },
                    { 6, "sport" },
                    { 7, "money" },
                    { 8, "movie" },
                    { 9, "dev" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthYear", "Created", "Edited", "EyeColor", "Gender", "HairColor", "Height", "HomeWorld", "Mass", "Name", "SkinColor", "Url" },
                values: new object[,]
                {
                    { 1, "19BBY", new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6011), new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6014), "blue", "male", "blond", "172", "https://swapi.dev/api/planets/1/", "77", "Luke Skywalker", "fair", "https://swapi.dev/api/people/1/" },
                    { 2, "112BBY", new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6026), new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6027), "yellow", "n/a", "n/a", "167", "https://swapi.dev/api/planets/1/", "75", "C-3PO", "fair", "https://swapi.dev/api/people/1/" },
                    { 3, "33BBY", new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6029), new DateTime(2022, 9, 28, 19, 54, 31, 380, DateTimeKind.Utc).AddTicks(6030), "red", "n/a", "n/a", "96", "https://swapi.dev/api/planets/1/", "32", "R2-D2", "white", "https://swapi.dev/api/people/1/" }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Name", "PeopleId" },
                values: new object[,]
                {
                    { 1, "https://swapi.dev/api/films/1/", 1 },
                    { 2, "https://swapi.dev/api/films/2/", 1 },
                    { 3, "https://swapi.dev/api/films/3/", 1 },
                    { 4, "https://swapi.dev/api/films/6/", 1 },
                    { 5, "https://swapi.dev/api/films/1/", 3 },
                    { 6, "https://swapi.dev/api/films/2/", 3 },
                    { 7, "https://swapi.dev/api/films/3/", 3 },
                    { 8, "https://swapi.dev/api/films/4/", 3 },
                    { 9, "https://swapi.dev/api/films/5/", 3 },
                    { 10, "https://swapi.dev/api/films/1/", 2 },
                    { 11, "https://swapi.dev/api/films/2/", 2 },
                    { 12, "https://swapi.dev/api/films/3/", 2 },
                    { 13, "https://swapi.dev/api/films/4/", 2 },
                    { 14, "https://swapi.dev/api/films/5/", 2 }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "PeopleId" },
                values: new object[,]
                {
                    { 1, "https://swapi.dev/api/species/2/", 2 },
                    { 2, "https://swapi.dev/api/species/2/", 3 }
                });

            migrationBuilder.InsertData(
                table: "Starship",
                columns: new[] { "Id", "Name", "PeopleId" },
                values: new object[,]
                {
                    { 1, "https://swapi.dev/api/starships/12/", 1 },
                    { 2, "https://swapi.dev/api/starships/22/", 1 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Name", "PeopleId" },
                values: new object[,]
                {
                    { 1, "https://swapi.dev/api/vehicles/14/", 1 },
                    { 2, "https://swapi.dev/api/vehicles/14/", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Starship",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Starship",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SkinColor",
                table: "People");
        }
    }
}
