using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeCChallenge.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirportWeathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_icao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_em = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressao_atmosferica = table.Column<int>(type: "int", nullable: false),
                    visibilidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vento = table.Column<int>(type: "int", nullable: false),
                    direcao_vento = table.Column<int>(type: "int", nullable: false),
                    umidade = table.Column<int>(type: "int", nullable: false),
                    condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    condicao_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportWeathers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityWeathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atualizado_em = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clima_data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityWeathers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirportWeathers");

            migrationBuilder.DropTable(
                name: "CityWeathers");
        }
    }
}
