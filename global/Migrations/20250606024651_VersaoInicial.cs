using System;
using Microsoft.EntityFrameworkCore.Migrations;
using static global.Migrations.DbConstants;

namespace global.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: LogApi,
                columns: table => new
                {
                    ID_LOG = table.Column<int>(type: Number10, nullable: false)
                        .Annotation(OracleIdentity, StartIncrement),
                    TIPO = table.Column<string>(type: NVarChar2000, nullable: false),
                    ENDPOINT = table.Column<string>(type: NVarChar2000, nullable: false),
                    PAYLOAD = table.Column<string>(type: NVarChar2000, nullable: false),
                    RESPOSTA = table.Column<string>(type: NVarChar2000, nullable: false),
                    DATA_HORA = table.Column<DateTime>(type: Timestamp7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOG_API", x => x.ID_LOG);
                });

            // Repita para PREVISAO_TEMPO, SENSORES, USUARIOS, LEITURA_SENSOR, ALERTA usando as constantes
            // e mantendo FKs e constraints
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: Alerta);
            migrationBuilder.DropTable(name: LeituraSensor);
            migrationBuilder.DropTable(name: Usuarios);
            migrationBuilder.DropTable(name: Sensores);
            migrationBuilder.DropTable(name: PrevisaoTempo);
            migrationBuilder.DropTable(name: LogApi);
        }
    }
}
