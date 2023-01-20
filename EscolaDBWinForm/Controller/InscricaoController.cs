using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;
namespace EscolaDBWinForm.Controller
{
    internal class InscricaoController
    {
        private IInscricaoView _view;
        private IInscricao _model;
        private BindingSource inscricaoBindingSource;
        private BindingSource ucBindingSource;
        private BindingSource anoBindingSource;
        private BindingSource eepocaBindingSource;
        private BindingSource epocaaBindingSource;
        private IEnumerable<Inscricao> inscricaoList;
        private ICollection<UnidadeCurricular> ucList;
        private ICollection<AnoLetivo> anoList;
        private ICollection<EstadoEpoca> eepocaList;
        private ICollection<EpocaAvaliacao> epocaaList;

        public InscricaoController(IInscricaoView view, IInscricao model)
        {
            _view = view;
            _model = model;
            inscricaoBindingSource = new BindingSource();
            ucBindingSource = new BindingSource();
            anoBindingSource = new BindingSource();
            eepocaBindingSource = new BindingSource();
            epocaaBindingSource = new BindingSource();

            inscricaoList = new List<Inscricao>();
            ucList = new List<UnidadeCurricular>();
            anoList = new List<AnoLetivo>();
            eepocaList = new List<EstadoEpoca>();
            epocaaList = new List<EpocaAvaliacao>();

            //Eventos
            _view.SearchEvent += SearchInscricao;
            _view.AddNewEvent += AddNewInscricao;
            _view.EditEvent += LoadSelectedtoEditInscricao;
            _view.DeleteEvent += DeleteInscricao;
            _view.SaveEvent += SaveInscricao;
            _view.CancelEvent += CancelAction;

            //Liga BindingSource para as GridViews
            _view.SetInscricaoListBindingSource(inscricaoBindingSource);

            //Liga BindingSource para as ComboBoxes
            _view.SetUCListBindingSource(ucBindingSource);
            _view.SetAnoListBindingSource(anoBindingSource);
            _view.SetEEpocaListBindingSource(eepocaBindingSource);
            _view.SetEpocaAListBindingSource(epocaaBindingSource);

            LoadInscricaoList();
            _view.Show();
        }

        private void LoadInscricaoList()
        {
            inscricaoList = _model.GetAll();
            inscricaoBindingSource.DataSource = inscricaoList;
        }

        private void LoadSelectedtoEditInscricao(object sender, EventArgs e)
        {
            /*3. A inscrição em Época de Avaliação de Recurso e Época Especial devem ser
   efetuadas manualmente e têm obrigatoriamente de existir uma época de avaliação
   imediatamente anterior válida, isto é, com o idEstadoEpoca preenchido com o
   correspondente à descrição “Reprovado”.
   A época imediatamente anterior à Época de Recurso é a Época Normal de Exame
   e a imediatamente anterior à Época Especial é a Época de Recurso.
*/
            //Cheka se a inscricao selecionada é valida para edição conforme a epoca de avaliacao e o estado da epoca
            //Se a epoca de avaliacao for EFRE - Epoca de Frequencia e a Nota for NULL, deixar o utilizador apenas introduzir a Nota e a Presenca
            //Se a epoca de avaliacao for uma qualquer e tiver o idEstadoEpoca 30 - Aprovado, nao deixar o utilizador introduzir nenhum campo, tudo read only.
            //Se a epoca de avalicao for ENEX - Epoca Normal de Exame e o idEstadoEpoca for 20 - Reprovado, colocar a epoca de avaliacao em EREC - Epoca de Recurso e o idEstadoEpoca em 10 - Adimitido, e so deixar o utilizador introduzir Nota e Presenca
            //Se a epoca de avaliacao for EREC - Epoca de Recurso e o idEstadoEpoca for 20 - Reprovado, colocar a epoca de avaliacao em EESP - Epoca Especial e o idEstadoEpoca em 10 - Adimitido, e so deixar o utilizador introduzir Nota e Presenca
            //Por fim se a epoca de avaliacao for EESP - Epoca Especial e o idEstadoEpoca for 20 - Reprovado, nao deixar o utilizador editar nenhum campo.
             
        }

        private void CancelAction(object sender, EventArgs e)
        {
            ClearView();
        }

        private void ClearView()
        {
            _view.NumeroAlunoInscricao = 0;
            _view.IdUCInscricao = 0;
            _view.IdAnoInscricao = 0;
            _view.IdEpocaAInscricao = "";
            _view.IdEEpocaInscricao = 0;
            _view.PresencaInscricao = "";
            _view.NotaInscricao = 0;
            _view.IsEdit = false;
        }
 /*Regras de Negócio
   1. A primeira inscrição de um aluno numa disciplina num dado ano letivo tem de ser
   sempre para a Época de Avaliação de Frequência;
   2. Uma inscrição em Época Normal de Exame é feita automaticamente quando:
   - É lançada uma nota com valor menor que dez (10), caso em que a
   presença deve ficar com o valor “P” e o idEstadoEpoca correspondente à
   descrição “Admitido”.
   - No caso de o aluno faltar a uma época de avaliação o campo presença deve
   ser preenchido com “F” e o idEstadoEpoca automaticamente preenchido
   com o correspondente à descrição “Admitido”.
      4. Em qualquer época de avaliação, o lançamento de uma nota com valor maior ou
   igual que dez (10), implica que que a presença deve ficar com o valor “P” e o
   idEstadoEpoca correspondente à descrição “Aprovado”.
   5. Não pode existir a inscrição numa época de avaliação subsequente a uma época
   de avaliação com o o idEstadoEpoca correspondente à descrição “Aprovado”.*/

        private void SaveInscricao(object? sender, EventArgs e)
        {
           
            var model = new Inscricao();
            //Cheka se e a primeira inscricao de um aluno numa disciplina num dado ano letivo
             

        }
    }
}
