using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EscolaDBWinForm.Models;

[Table("Docente")]
public partial class Docente
{
    [Key]
    [Column("numero")]
    public int Numero { get; set; }

    [Column("nomeProprio")]
    [StringLength(100)]
    public string NomeProprio { get; set; } = null!;

    [Column("apelido")]
    [StringLength(150)]
    public string Apelido { get; set; } = null!;

    [Column("dataNascimento", TypeName = "date")]
    public DateTime? DataNascimento { get; set; }

    [Column("email")]
    [StringLength(100)]
    public string? Email { get; set; }

    [Column("telefone")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Telefone { get; set; }

    [Column("extensao")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Extensao { get; set; }

    [Column("salario", TypeName = "decimal(10, 2)")]
    public decimal Salario { get; set; }


    [Browsable(false)]
    [InverseProperty("NumeroDocenteNavigation")]
    public virtual ICollection<UnidadeCurricular> UnidadeCurriculars { get; } = new List<UnidadeCurricular>();
}
