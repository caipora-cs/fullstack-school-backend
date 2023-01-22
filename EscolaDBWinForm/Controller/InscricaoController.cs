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

            //Metodos
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

            var inscricao = (Inscricao)inscricaoBindingSource.Current;
            //Popula as ComboBoxes 
            ucList = _model.GetUCList();
            anoList = _model.GetAnoList();
            eepocaList = _model.GetEEpocaList();
            epocaaList = _model.GetEpocaAList();
            ucBindingSource.DataSource = ucList;
            anoBindingSource.DataSource = anoList;
            eepocaBindingSource.DataSource = eepocaList;
            epocaaBindingSource.DataSource = epocaaList;

            //Realiza as edicoes
            _view.NumeroAlunoInscricao = inscricao.NumeroAluno;
            _view.IdUCInscricao = inscricao.IdUnidadeCurricular;
            _view.IdAnoInscricao = inscricao.IdAnoLetivo;
            if (inscricao.IdEstadoEpoca != null)
            {
                _view.IdEEpocaInscricao = inscricao.IdEstadoEpoca;
            }
            else { _view.IdEpocaAInscricao = ""; }
            _view.IdEpocaAInscricao = inscricao.IdEpocaAvaliacao;
            if (inscricao.Nota != null)
            {
                _view.NotaInscricao = inscricao.Nota;
            }
            else { _view.NotaInscricao = 0; }
            _view.PresencaInscricao = inscricao.Presenca;
            _view.IsEdit = true;

            /*            //Cheka se a inscricao selecionada é valida para edição conforme a epoca de avaliacao e o estado da epoca
                        //Se a epoca de avaliacao for EFRE - Epoca de Frequencia e a Nota for NULL, deixar o utilizador apenas introduzir a Nota e a Presenca
                        if (model.IdEpocaAvaliacao == "EFRE" && model.Nota == null)
                        {
                            _view.SetReadOnlyPresencaNotas();
                        }

                        //Se a epoca de avalicao for ENEX - Epoca Normal de Exame e o idEstadoEpoca for 20 - Reprovado, colocar a epoca de avaliacao em EREC - Epoca de Recurso e o idEstadoEpoca em 10 - Adimitido, e so deixar o utilizador introduzir Nota e Presenca
                        if (model.IdEpocaAvaliacao == "ENEX" && model.IdEstadoEpoca == 20)
                        {
                            _view.SetReadOnlyPresencaNotas();
                            _view.IdEpocaAInscricao = "EREC";
                            _view.IdEEpocaInscricao = 10;
                        }

                        //Se a epoca de avaliacao for EREC - Epoca de Recurso e o idEstadoEpoca for 20 - Reprovado, colocar a epoca de avaliacao em EESP - Epoca Especial e o idEstadoEpoca em 10 - Adimitido, e so deixar o utilizador introduzir Nota e Presenca
                        if (model.IdEpocaAvaliacao == "EREC" && model.IdEstadoEpoca == 20)
                        {
                            _view.SetReadOnlyPresencaNotas();
                            _view.IdEpocaAInscricao = "EESP";
                            _view.IdEEpocaInscricao = 10;
                        }

                        //Se a epoca de avaliacao for EESP - Epoca Especial e o idEstadoEpoca for 20 - Reprovado, nao deixar o utilizador editar nenhum campo.
                        if (model.IdEpocaAvaliacao == "EESP" && model.IdEstadoEpoca == 20)
                        {
                            _view.SetReadOnlyAll();
                        }

                        //Se a epoca de avaliacao for uma qualquer e tiver o idEstadoEpoca 30 - Aprovado, nao deixar o utilizador introduzir nenhum campo, tudo read only.
                        if (model.IdEstadoEpoca == 30)
                        {
                            _view.SetReadOnlyAll();
                        }*/
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
        }
        /*Regras de Negócio
          2. Uma inscrição em Época Normal de Exame é feita automaticamente quando:
          XXXX - É lançada uma nota com valor menor que dez (10), caso em que a
          presença deve ficar com o valor “P” e o idEstadoEpoca correspondente à
          descrição “Admitido”.
          - No caso de o aluno faltar a uma época de avaliação o campo presença deve
          ser preenchido com “F” e o idEstadoEpoca automaticamente preenchido
          com o correspondente à descrição “Admitido”.
          XXX 4. Em qualquer época de avaliação, o lançamento de uma nota com valor maior ou
          igual que dez (10), implica que que a presença deve ficar com o valor “P” e o
          idEstadoEpoca correspondente à descrição “Aprovado”.
          XXX 5. Não pode existir a inscrição numa época de avaliação subsequente a uma época
          de avaliação com o o idEstadoEpoca correspondente à descrição “Aprovado”.*/
        /*XXX 3. A inscrição em Época de Avaliação de Recurso e Época Especial devem ser
efetuadas manualmente e têm obrigatoriamente de existir uma época de avaliação
imediatamente anterior válida, isto é, com o idEstadoEpoca preenchido com o
correspondente à descrição “Reprovado”.
A época imediatamente anterior à Época de Recurso é a Época Normal de Exame
e a imediatamente anterior à Época Especial é a Época de Recurso.
*/

        private void AddNewInscricao(object sender, EventArgs e)
        {
            ClearView();
            //Popula as ComboBoxes
            ucList = _model.GetUCList();
            anoList = _model.GetAnoList();
            eepocaList = _model.GetEEpocaList();
            epocaaList = _model.GetEpocaAList();
            ucBindingSource.DataSource = ucList;
            anoBindingSource.DataSource = anoList;
            eepocaBindingSource.DataSource = eepocaList;
            epocaaBindingSource.DataSource = epocaaList;
            _view.IsEdit = false;
        }

        private void SaveInscricao(object? sender, EventArgs e)
        {

            var model = new Inscricao();
            model.NumeroAluno = _view.NumeroAlunoInscricao;
            model.IdUnidadeCurricular = _view.IdUCInscricao;
            model.IdAnoLetivo = _view.IdAnoInscricao;
            model.IdEpocaAvaliacao = _view.IdEpocaAInscricao;
            if (_view.IdEEpocaInscricao == 0)
            {
                model.IdEstadoEpoca = null;
            }
            else
            {
                model.IdEstadoEpoca = _view.IdEEpocaInscricao;
            }
            if (_view.PresencaInscricao == "")
            {
                model.Presenca = null;
            }
            else
            {
                model.Presenca = _view.PresencaInscricao;
            }
            if (_view.NotaInscricao == 0)
            {
                model.Nota = null;
            }
            else
            {
                model.Nota = _view.NotaInscricao;
            }
            //Regras de Negócio
            // 1. A primeira inscrição de um aluno numa disciplina num dado ano letivo tem de ser sempre para a Época de Avaliação de Frequência;
            // Vai buscar a lista de inscrições do aluno e verifica se já existe alguma inscrição para a UC e Ano selecionados
            var inscricaoList = _model.GetByValue(model.NumeroAluno);
            var inscricao = inscricaoList.Where(i => i.IdUnidadeCurricular == model.IdUnidadeCurricular && i.IdAnoLetivo == model.IdAnoLetivo).FirstOrDefault();
            if (inscricao == null)
            {
                if (model.IdEpocaAvaliacao != "EFRE")
                {
                    MessageBox.Show("A primeira inscrição de um aluno numa disciplina num dado ano letivo tem de ser sempre para a Época de Avaliação de Frequência");
                    return;
                }
            }

            // 2. Uma inscrição em Época Normal de Exame é feita automaticamente quando:
            // - É lançada uma nota com valor menor que dez (10), caso em que a presença deve ficar com o valor “P” e o idEstadoEpoca correspondente à descrição “Admitido”.
            // - No caso de o aluno faltar a uma época de avaliação o campo presença deve ser preenchido com “F” e o idEstadoEpoca automaticamente preenchido com o correspondente à descrição “Admitido”.
            if (model.IdEpocaAvaliacao == "EFRE")
            {
                if (model.Nota < 10 || model.Nota != null)
                {
                    model.Presenca = "P";
                    model.IdEstadoEpoca = 10;
                    //Adiciona uma Inscricao em Epoca Normal de Exame - ENEX para o aluno em questao 
                }
                else if (model.Presenca == "F")
                {
                    model.IdEstadoEpoca = 10;
                }
            }

            try
            {
                new ModelDataValidation().ValidateModelData(model);
                if (_view.IsEdit)
                {
                    _model.Edit(model);
                    _view.Message = "Inscrição editada com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Inscrição adicionada com sucesso!";
                }
                _view.IsSuccessful = true;
                _view.Message = "Inscrição guardada com sucesso!";
                LoadInscricaoList();
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                _view.IsSuccessful = false;
            }
            finally
            {
                ClearView();
            }

        }

        private void DeleteInscricao(object? sender, EventArgs e)
        {
            try
            {
                var model = (Inscricao)inscricaoBindingSource.Current;
                _model.Delete(model.NumeroAluno, model.IdUnidadeCurricular, model.IdAnoLetivo, model.IdEpocaAvaliacao);
                _view.Message = "Inscrição eliminada com sucesso";
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.Message = "Erro ao eliminar Inscricao";
                _view.IsSuccessful = false;
            }
            finally
            {
                LoadInscricaoList();
                ClearView();
            }
        }

        private void SearchInscricao(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                inscricaoList = _model.GetByValue(Convert.ToInt32(this._view.SearchValue));
                //Update da lista 
                inscricaoBindingSource.DataSource = inscricaoList;
            }
            else
            {
                //Carrega a lista no View
                LoadInscricaoList();
            }
        }


    }
}

