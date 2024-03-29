﻿// <auto-generated />
using System;
using EscolaDBWinForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EscolaDBWinForm.Migrations
{
    [DbContext(typeof(EscolaDbContext))]
    partial class EscolaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EscolaDBWinForm.Models.Aluno", b =>
                {
                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("apelido");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("dataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("image")
                        .HasColumnName("foto");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("morada");

                    b.Property<string>("NomeProprio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nomeProprio");

                    b.Property<int>("ReferenciaCurso")
                        .HasColumnType("int")
                        .HasColumnName("referenciaCurso");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("telefone")
                        .IsFixedLength();

                    b.HasKey("Numero")
                        .HasName("PK_Aluno_numero");

                    b.HasIndex("ReferenciaCurso");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.AnoLetivo", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<short>("AnoFinal")
                        .HasColumnType("smallint")
                        .HasColumnName("anoFinal");

                    b.Property<short>("AnoInicial")
                        .HasColumnType("smallint")
                        .HasColumnName("anoInicial");

                    b.HasKey("Id")
                        .HasName("PK_AnoLetivo_id");

                    b.ToTable("AnoLetivo");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Curso", b =>
                {
                    b.Property<int>("Referencia")
                        .HasColumnType("int")
                        .HasColumnName("referencia");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("dataInicio");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sigla");

                    b.HasKey("Referencia")
                        .HasName("PK_Curso_id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Docente", b =>
                {
                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("apelido");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("dataNascimento");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Extensao")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("extensao")
                        .IsFixedLength();

                    b.Property<string>("NomeProprio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nomeProprio");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("salario");

                    b.Property<string>("Telefone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("telefone")
                        .IsFixedLength();

                    b.HasKey("Numero")
                        .HasName("PK_Docente_numero");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.EpocaAvaliacao", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("id")
                        .IsFixedLength();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("PK_EpocaAvaliacao_id");

                    b.ToTable("EpocaAvaliacao");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.EstadoEpoca", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("PK_EstadoEpoca_id");

                    b.ToTable("EstadoEpoca");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Inscricao", b =>
                {
                    b.Property<int>("NumeroAluno")
                        .HasColumnType("int")
                        .HasColumnName("numeroAluno");

                    b.Property<int>("IdUnidadeCurricular")
                        .HasColumnType("int")
                        .HasColumnName("idUnidadeCurricular");

                    b.Property<short>("IdAnoLetivo")
                        .HasColumnType("smallint")
                        .HasColumnName("idAnoLetivo");

                    b.Property<string>("IdEpocaAvaliacao")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("idEpocaAvaliacao")
                        .IsFixedLength();

                    b.Property<short?>("IdEstadoEpoca")
                        .HasColumnType("smallint")
                        .HasColumnName("idEstadoEpoca");

                    b.Property<short?>("Nota")
                        .HasColumnType("smallint")
                        .HasColumnName("nota");

                    b.Property<string>("Presenca")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("presenca")
                        .IsFixedLength();

                    b.HasKey("NumeroAluno", "IdUnidadeCurricular", "IdAnoLetivo", "IdEpocaAvaliacao")
                        .HasName("PK_Inscricao_numeroAluno_idUnidadeCurricular_idAnoLetivo_idEpocaAvaliacao");

                    b.HasIndex("IdAnoLetivo");

                    b.HasIndex("IdEstadoEpoca");

                    b.HasIndex("IdUnidadeCurricular");

                    b.ToTable("Inscricao");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.UnidadeCurricular", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("ano")
                        .IsFixedLength();

                    b.Property<decimal>("Creditos")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("creditos");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("NumeroDocente")
                        .HasColumnType("int")
                        .HasColumnName("numeroDocente");

                    b.Property<int>("ReferenciaCurso")
                        .HasColumnType("int")
                        .HasColumnName("referenciaCurso");

                    b.Property<string>("Semestre")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("semestre")
                        .IsFixedLength();

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sigla");

                    b.HasKey("Id")
                        .HasName("PK_UnidadeCurricular_id");

                    b.HasIndex("NumeroDocente");

                    b.HasIndex("ReferenciaCurso");

                    b.ToTable("UnidadeCurricular");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Aluno", b =>
                {
                    b.HasOne("EscolaDBWinForm.Models.Curso", "ReferenciaCursoNavigation")
                        .WithMany("Alunos")
                        .HasForeignKey("ReferenciaCurso")
                        .IsRequired()
                        .HasConstraintName("FK_Aluno_Curso_referenciaCurso_referencia");

                    b.Navigation("ReferenciaCursoNavigation");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Inscricao", b =>
                {
                    b.HasOne("EscolaDBWinForm.Models.AnoLetivo", "IdAnoLetivoNavigation")
                        .WithMany("Inscricaos")
                        .HasForeignKey("IdAnoLetivo")
                        .IsRequired()
                        .HasConstraintName("FK_Inscricao_AnoLetivo_idAnoLetivo_id");

                    b.HasOne("EscolaDBWinForm.Models.EstadoEpoca", "IdEstadoEpocaNavigation")
                        .WithMany("Inscricaos")
                        .HasForeignKey("IdEstadoEpoca")
                        .HasConstraintName("FK_Inscricao_EstadoEpoca_idEstadoEpoca_id");

                    b.HasOne("EscolaDBWinForm.Models.UnidadeCurricular", "IdUnidadeCurricularNavigation")
                        .WithMany("Inscricaos")
                        .HasForeignKey("IdUnidadeCurricular")
                        .IsRequired()
                        .HasConstraintName("FK_Inscricao_UnidadeCurricular_idUnidadeCurricular_id");

                    b.HasOne("EscolaDBWinForm.Models.Aluno", "NumeroAlunoNavigation")
                        .WithMany("Inscricaos")
                        .HasForeignKey("NumeroAluno")
                        .IsRequired()
                        .HasConstraintName("FK_Inscricao_Aluno_numeroAluno_numero");

                    b.Navigation("IdAnoLetivoNavigation");

                    b.Navigation("IdEstadoEpocaNavigation");

                    b.Navigation("IdUnidadeCurricularNavigation");

                    b.Navigation("NumeroAlunoNavigation");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.UnidadeCurricular", b =>
                {
                    b.HasOne("EscolaDBWinForm.Models.Docente", "NumeroDocenteNavigation")
                        .WithMany("UnidadeCurriculars")
                        .HasForeignKey("NumeroDocente")
                        .IsRequired()
                        .HasConstraintName("FK_UnidadeCurricular_Docente_numeroDocente_numero");

                    b.HasOne("EscolaDBWinForm.Models.Curso", "ReferenciaCursoNavigation")
                        .WithMany("UnidadeCurriculars")
                        .HasForeignKey("ReferenciaCurso")
                        .IsRequired()
                        .HasConstraintName("FK_UnidadeCurricular_Curso_referenciaCurso_referencia");

                    b.Navigation("NumeroDocenteNavigation");

                    b.Navigation("ReferenciaCursoNavigation");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Aluno", b =>
                {
                    b.Navigation("Inscricaos");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.AnoLetivo", b =>
                {
                    b.Navigation("Inscricaos");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Curso", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("UnidadeCurriculars");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.Docente", b =>
                {
                    b.Navigation("UnidadeCurriculars");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.EstadoEpoca", b =>
                {
                    b.Navigation("Inscricaos");
                });

            modelBuilder.Entity("EscolaDBWinForm.Models.UnidadeCurricular", b =>
                {
                    b.Navigation("Inscricaos");
                });
#pragma warning restore 612, 618
        }
    }
}
