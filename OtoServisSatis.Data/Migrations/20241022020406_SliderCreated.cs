using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    public partial class SliderCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 22, 5, 4, 6, 167, DateTimeKind.Local).AddTicks(4468));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 22, 4, 6, 46, 179, DateTimeKind.Local).AddTicks(5769));
        }
    }
}
