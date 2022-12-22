using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("Curso")]
public partial class Curso
{
    [Key]
    [Column("referencia")]
    public int Referencia { get; set; }

    [Column("nome")]
    [StringLength(255)]
    public string Nome { get; set; } = null!;

    [Column("sigla")]
    [StringLength(10)]
    public string Sigla { get; set; } = null!;

    [Column("dataInicio", TypeName = "date")]
    public DateTime DataInicio { get; set; }

    [InverseProperty("ReferenciaCursoNavigation")]
    public virtual ICollection<Aluno> Alunos { get; } = new List<Aluno>();

    [InverseProperty("ReferenciaCursoNavigation")]
    public virtual ICollection<UnidadeCurricular> UnidadeCurriculars { get; } = new List<UnidadeCurricular>();
}
