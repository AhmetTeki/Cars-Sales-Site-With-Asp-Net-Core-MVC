using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    public partial class AracResimEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim1",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim2",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim3",
                table: "Araclar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 22, 4, 6, 46, 179, DateTimeKind.Local).AddTicks(5769));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim1",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim2",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim3",
                table: "Araclar");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 19, 14, 17, 32, 461, DateTimeKind.Local).AddTicks(4047));
        }
    }
}
