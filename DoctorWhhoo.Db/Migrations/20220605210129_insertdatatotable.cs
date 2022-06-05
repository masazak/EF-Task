using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhhoo.Db.Migrations
{
    public partial class insertdatatotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "hazem" },
                    { 2, "ahmad" },
                    { 3, "montaser" },
                    { 4, "mohammad" },
                    { 5, "omar" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Atheer", true },
                    { 2, "Aseel", false },
                    { 3, "Hadeel", true },
                    { 4, "Majed", false },
                    { 5, "Shahd", true }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamza", 597316748, new DateTime(2011, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adel", 597316748, new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibrahem", 597316748, new DateTime(2017, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1995, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar", 597316748, new DateTime(2011, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1994, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saef", 597316748, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemys",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "strong working hard", "Masa" },
                    { 2, "strong working hard", "Maya" },
                    { 3, "strong working hard", "Menna" },
                    { 4, "strong working hard", "Marah" },
                    { 5, "strong working hard", "Lana" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 4, 1, new DateTime(2011, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "action", " long episode", 123, "go" },
                    { 2, 4, 2, new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "horror", " long episode", 478, "be carefull" },
                    { 3, 3, 1, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "action", " long episode", 159, "sing" },
                    { 4, 2, 3, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "horror", " long episode", 867, "jump" },
                    { 5, 5, 4, new DateTime(2017, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "horror", " long episode", 989, "listen" }
                });

            migrationBuilder.InsertData(
                table: "EpEnemy",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 5, 3 },
                    { 4, 1, 1 },
                    { 5, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Epcomp",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 4, 5 },
                    { 2, 4, 4 },
                    { 3, 5, 2 },
                    { 4, 1, 1 },
                    { 5, 5, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpEnemy",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpEnemy",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpEnemy",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpEnemy",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpEnemy",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Epcomp",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Epcomp",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Epcomp",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Epcomp",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Epcomp",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);
        }
    }
}
