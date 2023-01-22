using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("AnoLetivo")]
public partial class AnoLetivo
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("anoInicial")]
    public short AnoInicial { get; set; }

    [Column("anoFinal")]
    public short AnoFinal { get; set; }

    [Browsable(false)]
    [InverseProperty("IdAnoLetivoNavigation")]
    public virtual ICollection<Inscricao> Inscricaos { get; } = new List<Inscricao>();
}
