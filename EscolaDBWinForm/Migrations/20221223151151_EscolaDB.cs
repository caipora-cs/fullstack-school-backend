using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaDBWinForm.Migrations
{
    /// <inheritdoc />
    public partial class EscolaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnoLetivo",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false),
                    anoInicial = table.Column<short>(type: "smallint", nullable: false),
                    anoFinal = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoLetivo_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    referencia = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    dataInicio = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso_id", x => x.referencia);
                });

            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    numero = table.Column<int>(type: "int", nullable: false),
                    nomeProprio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apelido = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "date", nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    telefone = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true),
                    extensao = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    salario = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente_numero", x => x.numero);
                });

            migrationBuilder.CreateTable(
                name: "EpocaAvaliacao",
                columns: table => new
                {
                    id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpocaAvaliacao_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoEpoca",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEpoca_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    numero = table.Column<int>(type: "int", nullable: false),
                    referenciaCurso = table.Column<int>(type: "int", nullable: false),
                    nomeProprio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apelido = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    morada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefone = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true),
                    foto = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno_numero", x => x.numero);
                    table.ForeignKey(
                        name: "FK_Aluno_Curso_referenciaCurso_referencia",
                        column: x => x.referenciaCurso,
                        principalTable: "Curso",
                        principalColumn: "referencia");
                });

            migrationBuilder.CreateTable(
                name: "UnidadeCurricular",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    referenciaCurso = table.Column<int>(type: "int", nullable: false),
                    numeroDocente = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    creditos = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ano = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    semestre = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeCurricular_id", x => x.id);
                    table.ForeignKey(
                        name: "FK_UnidadeCurricular_Curso_referenciaCurso_referencia",
                        column: x => x.referenciaCurso,
                        principalTable: "Curso",
                        principalColumn: "referencia");
                    table.ForeignKey(
                        name: "FK_UnidadeCurricular_Docente_numeroDocente_numero",
                        column: x => x.numeroDocente,
                        principalTable: "Docente",
                        principalColumn: "numero");
                });

            migrationBuilder.CreateTable(
                name: "Inscricao",
                columns: table => new
                {
                    numeroAluno = table.Column<int>(type: "int", nullable: false),
                    idUnidadeCurricular = table.Column<int>(type: "int", nullable: false),
                    idAnoLetivo = table.Column<short>(type: "smallint", nullable: false),
                    idEpocaAvaliacao = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    idEstadoEpoca = table.Column<short>(type: "smallint", nullable: true),
                    presenca = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    nota = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricao_numeroAluno_idUnidadeCurricular_idAnoLetivo_idEpocaAvaliacao", x => new { x.numeroAluno, x.idUnidadeCurricular, x.idAnoLetivo, x.idEpocaAvaliacao });
                    table.ForeignKey(
                        name: "FK_Inscricao_Aluno_numeroAluno_numero",
                        column: x => x.numeroAluno,
                        principalTable: "Aluno",
                        principalColumn: "numero");
                    table.ForeignKey(
                        name: "FK_Inscricao_AnoLetivo_idAnoLetivo_id",
                        column: x => x.idAnoLetivo,
                        principalTable: "AnoLetivo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Inscricao_EstadoEpoca_idEstadoEpoca_id",
                        column: x => x.idEstadoEpoca,
                        principalTable: "EstadoEpoca",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Inscricao_UnidadeCurricular_idUnidadeCurricular_id",
                        column: x => x.idUnidadeCurricular,
                        principalTable: "UnidadeCurricular",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_referenciaCurso",
                table: "Aluno",
                column: "referenciaCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_idAnoLetivo",
                table: "Inscricao",
                column: "idAnoLetivo");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_idEstadoEpoca",
                table: "Inscricao",
                column: "idEstadoEpoca");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricao_idUnidadeCurricular",
                table: "Inscricao",
                column: "idUnidadeCurricular");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeCurricular_numeroDocente",
                table: "UnidadeCurricular",
                column: "numeroDocente");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeCurricular_referenciaCurso",
                table: "UnidadeCurricular",
                column: "referenciaCurso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpocaAvaliacao");

            migrationBuilder.DropTable(
                name: "Inscricao");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "AnoLetivo");

            migrationBuilder.DropTable(
                name: "EstadoEpoca");

            migrationBuilder.DropTable(
                name: "UnidadeCurricular");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
