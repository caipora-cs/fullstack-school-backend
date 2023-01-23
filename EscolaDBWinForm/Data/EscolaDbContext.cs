using EscolaDBWinForm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static EscolaDBWinForm.Program;

namespace EscolaDBWinForm.Data;

public partial class EscolaDbContext : DbContext
{
    public EscolaDbContext()
    {
    }

    public EscolaDbContext(DbContextOptions<EscolaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<AnoLetivo> AnoLetivos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<EpocaAvaliacao> EpocaAvaliacaos { get; set; }

    public virtual DbSet<EstadoEpoca> EstadoEpocas { get; set; }

    public virtual DbSet<Inscricao> Inscricaos { get; set; }

    public virtual DbSet<UnidadeCurricular> UnidadeCurriculars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            BuildConfiguration();
            BuildOptions();
         
            var connString = _configuration.GetConnectionString("EscolaDB");

            _ = optionsBuilder.UseSqlServer(connString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK_Aluno_numero");
            //Ajustar para ser autoincrementado automaticamente na Db
            entity.Property(e => e.Numero).ValueGeneratedNever();
            entity.Property(e => e.Telefone).IsFixedLength();

            entity.HasOne(d => d.ReferenciaCursoNavigation).WithMany(p => p.Alunos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aluno_Curso_referenciaCurso_referencia");
        });

        modelBuilder.Entity<AnoLetivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AnoLetivo_id");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Referencia).HasName("PK_Curso_id");

            entity.Property(e => e.Referencia).ValueGeneratedNever();
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK_Docente_numero");

            entity.Property(e => e.Numero).ValueGeneratedNever();
            entity.Property(e => e.Extensao).IsFixedLength();
            entity.Property(e => e.Telefone).IsFixedLength();
        });

        modelBuilder.Entity<EpocaAvaliacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EpocaAvaliacao_id");

            entity.Property(e => e.Id).IsFixedLength();
        });

        modelBuilder.Entity<EstadoEpoca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EstadoEpoca_id");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Inscricao>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAluno, e.IdUnidadeCurricular, e.IdAnoLetivo, e.IdEpocaAvaliacao }).HasName("PK_Inscricao_numeroAluno_idUnidadeCurricular_idAnoLetivo_idEpocaAvaliacao");

            entity.Property(e => e.IdEpocaAvaliacao).IsFixedLength();
            entity.Property(e => e.Presenca).IsFixedLength();

            entity.HasOne(d => d.IdAnoLetivoNavigation).WithMany(p => p.Inscricaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_AnoLetivo_idAnoLetivo_id");

            entity.HasOne(d => d.IdEstadoEpocaNavigation).WithMany(p => p.Inscricaos).HasConstraintName("FK_Inscricao_EstadoEpoca_idEstadoEpoca_id");

            entity.HasOne(d => d.IdUnidadeCurricularNavigation).WithMany(p => p.Inscricaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_UnidadeCurricular_idUnidadeCurricular_id");

            entity.HasOne(d => d.NumeroAlunoNavigation).WithMany(p => p.Inscricaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_Aluno_numeroAluno_numero");
        });

        modelBuilder.Entity<UnidadeCurricular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UnidadeCurricular_id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ano).IsFixedLength();
            entity.Property(e => e.Semestre).IsFixedLength();

            entity.HasOne(d => d.NumeroDocenteNavigation).WithMany(p => p.UnidadeCurriculars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadeCurricular_Docente_numeroDocente_numero");

            entity.HasOne(d => d.ReferenciaCursoNavigation).WithMany(p => p.UnidadeCurriculars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadeCurricular_Curso_referenciaCurso_referencia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
