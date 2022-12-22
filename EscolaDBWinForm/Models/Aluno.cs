using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    [Column("numero")]
    public int Numero { get; set; }

    [Column("referenciaCurso")]
    public int ReferenciaCurso { get; set; }

    [Column("nomeProprio")]
    [StringLength(100)]
    public string NomeProprio { get; set; } = null!;

    [Column("apelido")]
    [StringLength(150)]
    public string Apelido { get; set; } = null!;

    [Column("dataNascimento", TypeName = "date")]
    public DateTime DataNascimento { get; set; }

    [Column("morada")]
    [StringLength(255)]
    public string Morada { get; set; } = null!;

    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; } = null!;

    [Column("telefone")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [Column("foto", TypeName = "image")]
    public byte[]? Foto { get; set; }

    [InverseProperty("NumeroAlunoNavigation")]
    public virtual ICollection<Inscricao> Inscricaos { get; } = new List<Inscricao>();

    [ForeignKey("ReferenciaCurso")]
    [InverseProperty("Alunos")]
    public virtual Curso ReferenciaCursoNavigation { get; set; } = null!;
}
