using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiseTechnology.Entities.Migrations
{
    public partial class Mg_Database_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KISILER",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: true),
                    Soyad = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: true),
                    FirmaBilgi = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: true),
                    KayitTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Ka_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Du_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Sil_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    Durum = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KISILER", x => x.ObjectID);
                });

            migrationBuilder.CreateTable(
                name: "RAPORLAR",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uuid", nullable: false),
                    RaporTalepTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RaporDurumBilgi = table.Column<int>(type: "integer", nullable: false),
                    KayitTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Ka_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Du_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Sil_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    Durum = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAPORLAR", x => x.ObjectID);
                });

            migrationBuilder.CreateTable(
                name: "KISI_ILETISIM_BILGILER",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uuid", nullable: false),
                    KisiID = table.Column<Guid>(type: "uuid", nullable: false),
                    IletisimBilgiTip = table.Column<int>(type: "integer", nullable: false),
                    Icerik = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    KayitTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Ka_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    DuzeltmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Du_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    SilmeTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Sil_KullaniciID = table.Column<int>(type: "integer", nullable: true),
                    Durum = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KISI_ILETISIM_BILGILER", x => x.ObjectID);
                    table.ForeignKey(
                        name: "FK_KISI_ILETISIM_BILGILER_KISILER_KisiID",
                        column: x => x.KisiID,
                        principalTable: "KISILER",
                        principalColumn: "ObjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KISI_ILETISIM_BILGILER_KisiID",
                table: "KISI_ILETISIM_BILGILER",
                column: "KisiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KISI_ILETISIM_BILGILER");

            migrationBuilder.DropTable(
                name: "RAPORLAR");

            migrationBuilder.DropTable(
                name: "KISILER");
        }
    }
}
