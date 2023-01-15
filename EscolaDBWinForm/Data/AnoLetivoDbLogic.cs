using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    internal class AnoLetivoDbLogic : EscolaDbContext, IAnoLetivo
    {
        private EscolaDbContext _context;

        public AnoLetivoDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(AnoLetivo ano)
        {
            _context.AnoLetivos.Add(ano);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ano = _context.AnoLetivos.Find(id);
            _context.AnoLetivos.Remove(ano);
            _context.SaveChanges();
        }

        public void Edit(AnoLetivo ano)
        {
            var anoToUpdate = _context.AnoLetivos.Find(ano.Id);
            anoToUpdate.AnoInicial = ano.AnoInicial;
            anoToUpdate.AnoFinal = ano.AnoFinal;
            _context.SaveChanges();
        }

        public IEnumerable<AnoLetivo> GetAll()
        {
            return _context.AnoLetivos.ToList();
        }

        public IEnumerable<AnoLetivo> GetByValue(string value)
        {
            //Procura por ano inicial ou final (short)
            return _context.AnoLetivos.Where(a => a.AnoInicial.ToString().Contains(value) || a.AnoFinal.ToString().Contains(value)).ToList();
        }

        //Busca todas as Inscricoes de um Ano para apresentar na gridview

        public ICollection<Inscricao> GetInscricao(int id)
        {
            return _context.Inscricaos.Where(i => i.IdAnoLetivo == id).ToList();
        }
    }
}
