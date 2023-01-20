using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IInscricao
    {
        void Add(Inscricao inscricao);
        void Edit(Inscricao inscricao);
        void Delete(int idAluno, int idUC, int idAnoLetivo, string idEpoca);

        IEnumerable<Inscricao> GetAll();
        IEnumerable<Inscricao> GetByValue(string value);
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAno(int idAluno, int idUC, int idAnoLetivo);
        //TODO: Overload aqui? 
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpoca(int idAluno, int idUC, int idAnoLetivo, int idEstadoEpoca);
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(int idAluno, int idUC, int idAnoLetivo, int idEstadoEpoca, string idEpocaAvaliacao);

    }
}
