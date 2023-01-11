using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;

namespace EscolaDBWinForm.Data
{
    internal class UCDbLogic : EscolaDbContext, IUnidadeCurricular
    {
        private EscolaDbContext _context;

        public UCDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(UnidadeCurricular uc)
        {
            _context.UnidadeCurriculars.Add(uc);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var uc = _context.UnidadeCurriculars.Find(id);
            _context.UnidadeCurriculars.Remove(uc);
            _context.SaveChanges();
        }

        public void Edit(UnidadeCurricular uc)
        {
            var ucToUpdate = _context.UnidadeCurriculars.Find(uc.Id);
            ucToUpdate.Nome = uc.Nome;
            ucToUpdate.Sigla = uc.Sigla;
            ucToUpdate.ReferenciaCurso = uc.ReferenciaCurso;
            ucToUpdate.NumeroDocente = uc.NumeroDocente;
            ucToUpdate.Creditos = uc.Creditos;
            ucToUpdate.Ano = uc.Ano;
            ucToUpdate.Semestre = uc.Semestre;
            _context.SaveChanges();
        }

        public IEnumerable<UnidadeCurricular> GetAll()
        {
            return _context.UnidadeCurriculars.ToList();
        }

        public IEnumerable<UnidadeCurricular> GetByValue(string value)
        {
            return _context.UnidadeCurriculars.Where(c => c.Nome.Contains(value) || c.Sigla.Contains(value)).ToList();
        }
    }
}
