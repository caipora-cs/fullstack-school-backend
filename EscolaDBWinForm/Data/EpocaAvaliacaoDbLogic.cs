using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;

namespace EscolaDBWinForm.Data
{
    internal class EpocaAvaliacaoDbLogic : EscolaDbContext, IEpocaAvaliacao
    {
        private EscolaDbContext _context;

        public EpocaAvaliacaoDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(EpocaAvaliacao epoca_a)
        {
            _context.EpocaAvaliacaos.Add(epoca_a);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var epoca_a = _context.EpocaAvaliacaos.Find(id);
            _context.EpocaAvaliacaos.Remove(epoca_a);
            _context.SaveChanges();
        }

        public void Edit(EpocaAvaliacao epoca_a)
        {
            var epoca_aToUpdate = _context.EpocaAvaliacaos.Find(epoca_a.Id);
            epoca_aToUpdate.Descricao = epoca_a.Descricao;
            _context.SaveChanges();
        }

        public IEnumerable<EpocaAvaliacao> GetAll()
        {
            return _context.EpocaAvaliacaos.ToList();
        }

        public IEnumerable<EpocaAvaliacao> GetByValue(string value)
        {
            return _context.EpocaAvaliacaos.Where(e => e.Descricao.Contains(value)).ToList();
        }
    }

}

