using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    internal class CursoDbLogic : EscolaDbContext, ICurso
    {
        private EscolaDbContext _context;

        public CursoDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var curso = _context.Cursos.Find(id);
            _context.Cursos.Remove(curso);
            _context.SaveChanges();
        }

        public void Edit(Curso curso)
        {
            var cursoToUpdate = _context.Cursos.Find(curso.Referencia);
                cursoToUpdate.Nome = curso.Nome;
                cursoToUpdate.Sigla = curso.Sigla;
                cursoToUpdate.DataInicio = curso.DataInicio;
                _context.SaveChanges();
        }

        public IEnumerable<Curso> GetAll()
        {
            return _context.Cursos.ToList();
        }

        public IEnumerable<Curso> GetByValue(string value)
        {
            return _context.Cursos.Where(c => c.Nome.Contains(value) || c.Sigla.Contains(value)).ToList();
        }

        //Busca todas as UCs de um curso para apresentar na gridview
        public ICollection<UnidadeCurricular> GetUCs(int id)
        {
            return _context.UnidadeCurriculars.Where(uc => uc.ReferenciaCurso == id).ToList();
        }

    }
}
