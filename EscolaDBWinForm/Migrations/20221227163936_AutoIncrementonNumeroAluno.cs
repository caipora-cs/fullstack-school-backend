using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaDBWinForm.Migrations
{
    /// <inheritdoc />
    public partial class AutoIncrementonNumeroAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Aluno",
                type: "char(12)",
                unicode: false,
                fixedLength: true,
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(12)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 12,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Aluno",
                type: "char(12)",
                unicode: false,
                fixedLength: true,
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(12)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 12);
        }
    }
}
