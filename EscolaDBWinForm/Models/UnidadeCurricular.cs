using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("UnidadeCurricular")]
public partial class UnidadeCurricular
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("referenciaCurso")]
    public int ReferenciaCurso { get; set; }

    [Column("numeroDocente")]
    public int NumeroDocente { get; set; }

    [Column("nome")]
    [StringLength(100)]
    public string Nome { get; set; } = null!;

    [Column("sigla")]
    [StringLength(10)]
    public string Sigla { get; set; } = null!;

    [Column("creditos", TypeName = "decimal(10, 2)")]
    public decimal Creditos { get; set; }

    [Column("ano")]
    [StringLength(1)]
    [Unicode(false)]
    public string Ano { get; set; } = null!;

    [Column("semestre")]
    [StringLength(1)]
    [Unicode(false)]
    public string Semestre { get; set; } = null!;


    [Browsable(false)]
    [InverseProperty("IdUnidadeCurricularNavigation")]
    public virtual ICollection<Inscricao> Inscricaos { get; } = new List<Inscricao>();

    
    [Browsable(false)]
    [ForeignKey("NumeroDocente")]
    [InverseProperty("UnidadeCurriculars")]
    public virtual Docente NumeroDocenteNavigation { get; set; } = null!;


    [Browsable(false)]
    [ForeignKey("ReferenciaCurso")]
    [InverseProperty("UnidadeCurriculars")]
    public virtual Curso ReferenciaCursoNavigation { get; set; } = null!;
}
