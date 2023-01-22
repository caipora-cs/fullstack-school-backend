using EscolaDBWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Data
{
    internal class InscricaoDbLogic : EscolaDbContext, IInscricao
    {
        private EscolaDbContext _context;

        public InscricaoDbLogic()
        {
            _context = new EscolaDbContext();
        }

        public void Add(Inscricao inscricao)
        {
            _context.Inscricaos.Add(inscricao);
            _context.SaveChanges();
        }

        //Deleta uma inscricao baseado no numero do aluno, idunidadecurricular, idanoletivo e id epoca avaliacao
        public void Delete(int idAluno, int idUC, short idAnoLetivo, string idEpoca)
        {
            var inscricao = _context.Inscricaos.Find(idAluno, idUC, idAnoLetivo, idEpoca);
            _context.Inscricaos.Remove(inscricao);
            _context.SaveChanges();
        }

        public void Edit(Inscricao inscricao)
        { 
            var inscricaoToUpdate = _context.Inscricaos
                .Where(i => i.NumeroAluno == inscricao.NumeroAluno)
                .Where(i => i.IdUnidadeCurricular == inscricao.IdUnidadeCurricular)
                .Where(i => i.IdAnoLetivo == inscricao.IdAnoLetivo)
                .Where(i => i.IdEpocaAvaliacao == inscricao.IdEpocaAvaliacao)
                .FirstOrDefault();

            inscricaoToUpdate.Nota = inscricao.Nota;
            inscricaoToUpdate.IdEstadoEpoca = inscricao.IdEstadoEpoca;
            inscricaoToUpdate.Presenca = inscricao.Presenca;
            _context.SaveChanges();
        }

        public IEnumerable<Inscricao> GetAll()
        {
            return _context.Inscricaos.ToList();
        }

        public IEnumerable<Inscricao> GetByValue(int value)
        {
            //Procura uma inscricao com um metodo de Entitity Framework por numero do aluno ou idunidadecurricular ou idanoletivo em int
            return _context.Inscricaos.Where(i => i.NumeroAluno == value || i.IdUnidadeCurricular == value).ToList();
        }

        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAno(int idAluno, int idUC, short idAnoLetivo)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo).ToList();
        }

        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpoca(int idAluno, int idUC, short idAnoLetivo, short idEstadoEpoca)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo && i.IdEstadoEpoca == idEstadoEpoca).ToList();
        }


        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(int idAluno, int idUC, short idAnoLetivo, short idEstadoEpoca, string idEpocaAvaliacao)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo && i.IdEstadoEpoca == idEstadoEpoca && i.IdEpocaAvaliacao == idEpocaAvaliacao).ToList();
        }

        public ICollection<UnidadeCurricular> GetUCList()
        {
            return _context.UnidadeCurriculars.ToList();
        }

        public ICollection<AnoLetivo> GetAnoList()
        {
            return _context.AnoLetivos.ToList();
        }

        public ICollection<EpocaAvaliacao> GetEpocaAList()
        {
            return _context.EpocaAvaliacaos.ToList();
        }

        public ICollection<EstadoEpoca> GetEEpocaList()
        {
            return _context.EstadoEpocas.ToList();
        }
    }
}
