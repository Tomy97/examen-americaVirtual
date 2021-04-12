using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class relacion_Ciudades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Ciudades",
                type: "int",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_PaisId",
                table: "Ciudades",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Paises_PaisId",
                table: "Ciudades",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Paises_PaisId",
                table: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_PaisId",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Ciudades");
        }
    }
}
