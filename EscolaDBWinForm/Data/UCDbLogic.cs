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
        
        //Metodo para buscar UCs por curso, ano, semestre 
        public IEnumerable<UnidadeCurricular> GetByValue(string value)
        {
            //Possivel filtrar as UCs por curso, ano, semestre, nome e sigla
            return _context.UnidadeCurriculars.Where(uc => uc.Nome.Contains(value) || uc.Sigla.Contains(value) || uc.Ano.Contains(value) ||uc.Semestre.Contains(value)||uc.ReferenciaCurso.ToString().Contains(value)).ToList();

        }

        public ICollection<Inscricao> GetInscricao(int id)
        {
            return _context.Inscricaos.Where(i => i.IdUnidadeCurricular == id).ToList();
        }
    }
}
