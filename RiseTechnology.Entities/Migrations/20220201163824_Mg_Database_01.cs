using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiseTechnology.Entities.Migrations
{
    public partial class Mg_Database_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KISI_ILETISIM_BILGILER",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IletisimBilgiTip = table.Column<int>(type: "int", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Kaydeden_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duzenleyen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Silen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KISI_ILETISIM_BILGILER", x => x.ObjectID);
                });

            migrationBuilder.CreateTable(
                name: "KISILER",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    FirmaBilgi = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    KayitTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Kaydeden_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duzenleyen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Silen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KISILER", x => x.ObjectID);
                });

            migrationBuilder.CreateTable(
                name: "RAPORLAR",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaporTalepTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RaporDurumBilgi = table.Column<int>(type: "int", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Kaydeden_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duzenleyen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Silen_KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAPORLAR", x => x.ObjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KISI_ILETISIM_BILGILER");

            migrationBuilder.DropTable(
                name: "KISILER");

            migrationBuilder.DropTable(
                name: "RAPORLAR");
        }
    }
}
