using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class ciudades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre", "PaisId" },
                values: new object[,] {
                    { 1, "CABA",  1}, { 2, "Escobar", 1 },{ 3, "La Plata",1 }, {4, "Berazategui", 1}, {5, "Bahia Blanca", 1 }, {6, "Mar Del Plata", 1},
                    { 7, "Montevideo",  2}, { 8, "Punta del Este", 2 },
                    { 9, "Santiago de Chile",  3}, { 10, "ValParaiso", 3 }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
