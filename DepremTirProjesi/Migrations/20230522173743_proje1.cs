using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepremTirProjesi.Migrations
{
    /// <inheritdoc />
    public partial class proje1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorevlis",
                columns: table => new
                {
                    GorevliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevliAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorevliSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorevliKayitNo = table.Column<int>(type: "int", nullable: false),
                    GorevliYasi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlis", x => x.GorevliId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Malzemes",
                columns: table => new
                {
                    MalzemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalzemeAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeStok = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malzemes", x => x.MalzemeId);
                    table.ForeignKey(
                        name: "FK_Malzemes_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    IlceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.IlceId);
                    table.ForeignKey(
                        name: "FK_Ilces_Sehirs_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirs",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TirİcerikBilgisis",
                columns: table => new
                {
                    TirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TirPlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    MalzemeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TirİcerikBilgisis", x => x.TirId);
                    table.ForeignKey(
                        name: "FK_TirİcerikBilgisis_Malzemes_MalzemeId",
                        column: x => x.MalzemeId,
                        principalTable: "Malzemes",
                        principalColumn: "MalzemeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TirİcerikBilgisis_Sehirs_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirs",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_SehirId",
                table: "Ilces",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Malzemes_KategoriId",
                table: "Malzemes",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_TirİcerikBilgisis_MalzemeId",
                table: "TirİcerikBilgisis",
                column: "MalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_TirİcerikBilgisis_SehirId",
                table: "TirİcerikBilgisis",
                column: "SehirId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorevlis");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "TirİcerikBilgisis");

            migrationBuilder.DropTable(
                name: "Malzemes");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
