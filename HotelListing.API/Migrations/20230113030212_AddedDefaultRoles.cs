using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "139e6890-bbf8-46cd-b985-c8315671747f", "07401985-5810-4180-a8a8-bd87598c5f70", "Administrator", "ADMINISTRATOR" },
                    { "4a5ed3a6-2e62-4031-825a-2561a8f233aa", "dcdb06e9-fc8a-414f-aa63-035804d34794", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "139e6890-bbf8-46cd-b985-c8315671747f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5ed3a6-2e62-4031-825a-2561a8f233aa");
        }
    }
}
