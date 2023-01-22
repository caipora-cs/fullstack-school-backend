using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    [DisplayName("Curso")]
    [Column("referenciaCurso")]
    public int ReferenciaCurso { get; set; }

    [Column("nomeProprio")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome próprio deve ter entre 3 e 100 caracteres")]
    [Required(ErrorMessage = "O nome do Aluno é obrigatório")]
    public string NomeProprio { get; set; } = null!;

    [Column("apelido")]
    [StringLength(150)]
    [Required(ErrorMessage = "O apelido do Aluno é obrigatório")]
    public string Apelido { get; set; } = null!;

    [Column("dataNascimento", TypeName = "date")]
    [Required(ErrorMessage = "A data de nascimento do Aluno é obrigatória")]
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
    [Required(ErrorMessage = "O telefone do Aluno é obrigatório")]
    public string? Telefone { get; set; }

    [Column("foto", TypeName = "image")]
    public byte[]? Foto { get; set; }

    //DataAnnotation para esconder a coluna Inscricoes na GridView
    [Browsable(false)]
    [DisplayName("Iscricoes")]
    [InverseProperty("NumeroAlunoNavigation")]
    public virtual ICollection<Inscricao> Inscricaos { get; } = new List<Inscricao>();

    //DataAnnotation para esconder a coluna ReferenciaCurso na GridView
    [Browsable(false)]
    [ForeignKey("ReferenciaCurso")]
    [InverseProperty("Alunos")]
    public virtual Curso ReferenciaCursoNavigation { get; set; } = null!;
}
