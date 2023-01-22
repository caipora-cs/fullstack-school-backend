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
        void Delete(int idAluno, int idUC, short idAnoLetivo, string idEpoca);

        IEnumerable<Inscricao> GetAll();
        IEnumerable<Inscricao> GetByValue(int value);
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAno(int idAluno, int idUC, short idAnoLetivo);
        //TODO: Overload aqui? 
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpoca(int idAluno, int idUC, short idAnoLetivo, short idEstadoEpoca);
        IEnumerable<Inscricao> GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(int idAluno, int idUC, short idAnoLetivo, short idEstadoEpoca, string idEpocaAvaliacao);
        //ComboBoxes
        ICollection<UnidadeCurricular> GetUCList();
        ICollection<AnoLetivo> GetAnoList();
        ICollection<EpocaAvaliacao> GetEpocaAList();
        ICollection<EstadoEpoca> GetEEpocaList();

    }
}
