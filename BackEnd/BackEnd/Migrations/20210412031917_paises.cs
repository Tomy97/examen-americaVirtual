using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class paises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,] {
                    { 1, "Argentina" }, { 2, "Uruguay" }, { 3, "Chile" }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
