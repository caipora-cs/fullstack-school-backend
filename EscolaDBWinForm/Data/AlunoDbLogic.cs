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
            _context.Entry(aluno).State = EntityState.Modified;
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
   
