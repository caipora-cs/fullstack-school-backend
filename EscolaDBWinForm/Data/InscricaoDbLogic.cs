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
        public void Delete(int idAluno, int idUC, int idAnoLetivo, string idEpoca)
        {
            var inscricao = _context.Inscricaos.Find(idAluno, idUC, idAnoLetivo, idEpoca);
            _context.Inscricaos.Remove(inscricao);
            _context.SaveChanges();
        }

        public void Edit(Inscricao inscricao)
        {
            var inscricaoToUpdate = _context.Inscricaos.Find(inscricao.NumeroAluno, inscricao.IdUnidadeCurricular, inscricao.IdAnoLetivo, inscricao.IdEpocaAvaliacao);
            inscricaoToUpdate.Nota = inscricao.Nota;
            inscricaoToUpdate.IdEstadoEpoca = inscricao.IdEstadoEpoca;
            inscricaoToUpdate.Presenca = inscricao.Presenca;
            _context.SaveChanges();
        }

        public IEnumerable<Inscricao> GetAll()
        {
            return _context.Inscricaos.ToList();
        }

        //Procura uma inscricao por numero do aluno ou idunidadecurricular ou idanoletivo ou id epoca avaliacao
        public IEnumerable<Inscricao> GetByValue(string value)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno.ToString().Contains(value) || i.IdUnidadeCurricular.ToString().Contains(value) || i.IdAnoLetivo.ToString().Contains(value) || i.IdEpocaAvaliacao.ToString().Contains(value)).ToList();
        }

        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAno(int idAluno, int idUC, int idAnoLetivo)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo).ToList();
        }

        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpoca(int idAluno, int idUC, int idAnoLetivo, int idEstadoEpoca)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo && i.IdEstadoEpoca == idEstadoEpoca).ToList();
        }


        public IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(int idAluno, int idUC, int idAnoLetivo, int idEstadoEpoca, string idEpocaAvaliacao)
        {
            return _context.Inscricaos.Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC && i.IdAnoLetivo == idAnoLetivo && i.IdEstadoEpoca == idEstadoEpoca && i.IdEpocaAvaliacao == idEpocaAvaliacao).ToList();
        }
    }
}
