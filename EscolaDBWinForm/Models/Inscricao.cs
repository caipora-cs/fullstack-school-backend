using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[PrimaryKey("NumeroAluno", "IdUnidadeCurricular", "IdAnoLetivo", "IdEpocaAvaliacao")]
[Table("Inscricao")]
public partial class Inscricao
{
    [Key]
    [Column("numeroAluno")]
    public int NumeroAluno { get; set; }

    [Key]
    [Column("idUnidadeCurricular")]
    public int IdUnidadeCurricular { get; set; }

    [Key]
    [Column("idAnoLetivo")]
    public short IdAnoLetivo { get; set; }

    [Key]
    [Column("idEpocaAvaliacao")]
    [StringLength(4)]
    [Unicode(false)]
    public string IdEpocaAvaliacao { get; set; } = null!;

    [Column("idEstadoEpoca")]
    public short? IdEstadoEpoca { get; set; }

    [Column("presenca")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Presenca { get; set; }

    [Column("nota")]
    public short? Nota { get; set; }

    [Browsable(false)]
    [ForeignKey("IdAnoLetivo")]
    [InverseProperty("Inscricaos")]
    public virtual AnoLetivo IdAnoLetivoNavigation { get; set; } = null!;

    [Browsable(false)]
    [ForeignKey("IdEstadoEpoca")]
    [InverseProperty("Inscricaos")]
    public virtual EstadoEpoca? IdEstadoEpocaNavigation { get; set; }

    [Browsable(false)]
    [ForeignKey("IdUnidadeCurricular")]
    [InverseProperty("Inscricaos")]
    public virtual UnidadeCurricular IdUnidadeCurricularNavigation { get; set; } = null!;

    [Browsable(false)]
    [ForeignKey("NumeroAluno")]
    [InverseProperty("Inscricaos")]
    public virtual Aluno NumeroAlunoNavigation { get; set; } = null!;
}
