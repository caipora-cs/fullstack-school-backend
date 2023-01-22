using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("EstadoEpoca")]
public partial class EstadoEpoca
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("descricao")]
    [StringLength(50)]
    public string Descricao { get; set; } = null!;


    [Browsable(false)]
    [InverseProperty("IdEstadoEpocaNavigation")]
    public virtual ICollection<Inscricao> Inscricaos { get; } = new List<Inscricao>();
}
