using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    public partial class Düzenleme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 19, 14, 17, 32, 461, DateTimeKind.Local).AddTicks(4047));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 16, 23, 38, 14, 269, DateTimeKind.Local).AddTicks(2289));
        }
    }
}
