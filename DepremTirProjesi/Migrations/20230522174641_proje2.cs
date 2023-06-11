using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepremTirProjesi.Migrations
{
    /// <inheritdoc />
    public partial class proje2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "TirİcerikBilgisis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TirİcerikBilgisis_IlceId",
                table: "TirİcerikBilgisis",
                column: "IlceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TirİcerikBilgisis_Ilces_IlceId",
                table: "TirİcerikBilgisis",
                column: "IlceId",
                principalTable: "Ilces",
                principalColumn: "IlceId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TirİcerikBilgisis_Ilces_IlceId",
                table: "TirİcerikBilgisis");

            migrationBuilder.DropIndex(
                name: "IX_TirİcerikBilgisis_IlceId",
                table: "TirİcerikBilgisis");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "TirİcerikBilgisis");
        }
    }
}
