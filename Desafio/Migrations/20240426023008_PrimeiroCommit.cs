using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiroCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Episodio = table.Column<string>(type: "TEXT", nullable: true),
                    TextoAbertura = table.Column<string>(type: "TEXT", nullable: true),
                    Diretor = table.Column<string>(type: "TEXT", nullable: true),
                    Produtor = table.Column<string>(type: "TEXT", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavesEstelares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: true),
                    Custo = table.Column<string>(type: "TEXT", nullable: true),
                    Comprimento = table.Column<string>(type: "TEXT", nullable: true),
                    VelocidadeMaxima = table.Column<string>(type: "TEXT", nullable: true),
                    Tripulacao = table.Column<string>(type: "TEXT", nullable: true),
                    Passageiros = table.Column<string>(type: "TEXT", nullable: true),
                    CapacidadeCarga = table.Column<string>(type: "TEXT", nullable: true),
                    ClassificacaoHyperDrive = table.Column<string>(type: "TEXT", nullable: true),
                    Mglt = table.Column<string>(type: "TEXT", nullable: true),
                    Consumiveis = table.Column<string>(type: "TEXT", nullable: true),
                    Classe = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavesEstelares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    PeriodoRotacao = table.Column<string>(type: "TEXT", nullable: true),
                    PeriodoOrbita = table.Column<string>(type: "TEXT", nullable: true),
                    Diametro = table.Column<string>(type: "TEXT", nullable: true),
                    Clima = table.Column<string>(type: "TEXT", nullable: true),
                    Gravidade = table.Column<string>(type: "TEXT", nullable: true),
                    Terreno = table.Column<string>(type: "TEXT", nullable: true),
                    SuperficeAquatica = table.Column<string>(type: "TEXT", nullable: true),
                    Populacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: true),
                    CustoEmCredito = table.Column<string>(type: "TEXT", nullable: true),
                    Comprimento = table.Column<string>(type: "TEXT", nullable: true),
                    VelocidadeMaxima = table.Column<string>(type: "TEXT", nullable: true),
                    Tripulacao = table.Column<string>(type: "TEXT", nullable: true),
                    Passageiros = table.Column<string>(type: "TEXT", nullable: true),
                    CapacidadeCarga = table.Column<string>(type: "TEXT", nullable: true),
                    Consumiveis = table.Column<string>(type: "TEXT", nullable: true),
                    Classe = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmeNaveEstelar",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    NavesEstelaresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeNaveEstelar", x => new { x.FilmesId, x.NavesEstelaresId });
                    table.ForeignKey(
                        name: "FK_FilmeNaveEstelar_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeNaveEstelar_NavesEstelares_NavesEstelaresId",
                        column: x => x.NavesEstelaresId,
                        principalTable: "NavesEstelares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmePlaneta",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanetasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmePlaneta", x => new { x.FilmesId, x.PlanetasId });
                    table.ForeignKey(
                        name: "FK_FilmePlaneta_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmePlaneta_Planetas_PlanetasId",
                        column: x => x.PlanetasId,
                        principalTable: "Planetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Altura = table.Column<string>(type: "TEXT", nullable: true),
                    Pesa = table.Column<string>(type: "TEXT", nullable: true),
                    CorCabelo = table.Column<string>(type: "TEXT", nullable: true),
                    CorPele = table.Column<string>(type: "TEXT", nullable: true),
                    CorOlho = table.Column<string>(type: "TEXT", nullable: true),
                    AnoNascimento = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    PlanetaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personagens_Planetas_PlanetaId",
                        column: x => x.PlanetaId,
                        principalTable: "Planetas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FilmeVeiculo",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeículosFilmeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeVeiculo", x => new { x.FilmesId, x.VeículosFilmeId });
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Veiculos_VeículosFilmeId",
                        column: x => x.VeículosFilmeId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmePersonagem",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonagensId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmePersonagem", x => new { x.FilmesId, x.PersonagensId });
                    table.ForeignKey(
                        name: "FK_FilmePersonagem_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmePersonagem_Personagens_PersonagensId",
                        column: x => x.PersonagensId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmeNaveEstelar_NavesEstelaresId",
                table: "FilmeNaveEstelar",
                column: "NavesEstelaresId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmePersonagem_PersonagensId",
                table: "FilmePersonagem",
                column: "PersonagensId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmePlaneta_PlanetasId",
                table: "FilmePlaneta",
                column: "PlanetasId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeVeiculo_VeículosFilmeId",
                table: "FilmeVeiculo",
                column: "VeículosFilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_PlanetaId",
                table: "Personagens",
                column: "PlanetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmeNaveEstelar");

            migrationBuilder.DropTable(
                name: "FilmePersonagem");

            migrationBuilder.DropTable(
                name: "FilmePlaneta");

            migrationBuilder.DropTable(
                name: "FilmeVeiculo");

            migrationBuilder.DropTable(
                name: "NavesEstelares");

            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Planetas");
        }
    }
}
