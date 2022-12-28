using EscolaDBWinForm.Models;
using Microsoft.EntityFrameworkCore;
using EscolaDBWinForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    public class AlunoDbLogic : EscolaDbContext, IAluno
    {
        //Fields
        private EscolaDbContext _context;

        //Constructor
        public AlunoDbLogic()
        {
            _context = new EscolaDbContext();
        }

        //Metodos
        public void Add(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var aluno = _context.Alunos.Find(id);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }

         
        public void Edit(Aluno aluno)
        {
            //update aluno NomeProprio, Apelido , DataNascimento , Morada , Email , Telefone , Curso , AnoCurso where Numero = view NumeroAluno in Entity Framework 
            //The instance of entity type "Aluno" cannot be tracked because another instance with the same key value {'Numero'} is already being tracked.
            //Ensure that only one entity instance with a given key value is attached
            //Fix it
            
            var alunoToUpdate = _context.Alunos.Find(aluno.Numero);
            alunoToUpdate.NomeProprio = aluno.NomeProprio;
            alunoToUpdate.Apelido = aluno.Apelido;
            alunoToUpdate.DataNascimento = aluno.DataNascimento;
            alunoToUpdate.Morada = aluno.Morada;
            alunoToUpdate.Email = aluno.Email;
            alunoToUpdate.Telefone = aluno.Telefone;
            alunoToUpdate.ReferenciaCurso = aluno.ReferenciaCurso;
            _context.SaveChanges();
            
        }

        public IEnumerable<Aluno> GetAll()
        {
            //Lista de todos os Alunos
            return _context.Alunos.ToList();
        }

        public IEnumerable<Aluno> GetByValue(string value)
        {
            //Pesquise por NomeProprio(string) ou por Numero(int) de Aluno
            return _context.Alunos.Where(a => a.NomeProprio.Contains(value) || a.Numero.ToString().Contains(value)).ToList();
        }

    }
}
   
