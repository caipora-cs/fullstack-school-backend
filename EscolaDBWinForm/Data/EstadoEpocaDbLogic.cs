using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    internal class EstadoEpocaDbLogic : EscolaDbContext, IEstadoEpoca
    {
        private EscolaDbContext _context;

        public EstadoEpocaDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(EstadoEpoca e_epoca)
        {
            _context.EstadoEpocas.Add(e_epoca);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var e_epoca = _context.EstadoEpocas.Find(id);
            _context.EstadoEpocas.Remove(e_epoca);
            _context.SaveChanges();
        }

        public void Edit(EstadoEpoca e_epoca)
        {
            var e_epocaToUpdate = _context.EstadoEpocas.Find(e_epoca.Id);
            e_epocaToUpdate.Descricao = e_epoca.Descricao;
            _context.SaveChanges();
        }

        public IEnumerable<EstadoEpoca> GetAll()
        {
            return _context.EstadoEpocas.ToList();
        }

        public IEnumerable<EstadoEpoca> GetByValue(string value)
        {
            return _context.EstadoEpocas.Where(e => e.Descricao.Contains(value)).ToList();
        }

        //Busca todas as Inscricoes de uma Epoca para apresentar na gridview

        public ICollection<Inscricao> GetInscricao(int id)
        {
            return _context.Inscricaos.Where(i => i.IdEstadoEpoca == id).ToList();
        }
    }
}
