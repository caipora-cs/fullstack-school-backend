using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    internal class DocenteDbLogic : EscolaDbContext, IDocente
    {
        private EscolaDbContext _context;

        public DocenteDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(Docente docente)
        {
            _context.Docentes.Add(docente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var docente = _context.Docentes.Find(id);
            _context.Docentes.Remove(docente);
            _context.SaveChanges();
        }

        public void Edit(Docente docente)
        {
            var docenteToUpdate = _context.Docentes.Find(docente.Numero);
            docenteToUpdate.NomeProprio = docente.NomeProprio;
            docenteToUpdate.Apelido = docente.Apelido;
            docenteToUpdate.DataNascimento = docente.DataNascimento;
            docenteToUpdate.Email = docente.Email;
            docenteToUpdate.Telefone = docente.Telefone;
            docenteToUpdate.Extensao = docente.Extensao;
            docenteToUpdate.Salario = docente.Salario;
            _context.SaveChanges();
        }

        public IEnumerable<Docente> GetAll()
        {
            return _context.Docentes.ToList();
        }

        public IEnumerable<Docente> GetByValue(string value)
        {
            return _context.Docentes.Where(d => d.NomeProprio.Contains(value) || d.Apelido.Contains(value)).ToList();
        }

        public ICollection<UnidadeCurricular> GetUCs(int id)
        {
            return _context.UnidadeCurriculars.Where(uc => uc.NumeroDocente == id).ToList();
        }
    }
}
