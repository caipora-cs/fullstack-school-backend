using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("EpocaAvaliacao")]
public partial class EpocaAvaliacao
{
    [Key]
    [Column("id")]
    [StringLength(4)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("descricao")]
    [StringLength(100)]
    public string Descricao { get; set; } = null!;
}
