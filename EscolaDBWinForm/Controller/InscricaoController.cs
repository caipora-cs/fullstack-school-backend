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
            ucBindingSource.DataSource = ucList;
            anoBindingSource.DataSource = anoList;
            eepocaBindingSource.DataSource = eepocaList;
            epocaaBindingSource.DataSource = epocaaList;

            //Realiza as edicoes
            _view.NumeroAlunoInscricao = inscricao.NumeroAluno;
            _view.IdUCInscricao = inscricao.IdUnidadeCurricular;
            _view.IdAnoInscricao = inscricao.IdAnoLetivo;
            _view.IdEEpocaInscricao = (short)inscricao.IdEstadoEpoca;
            _view.IdEpocaAInscricao = inscricao.IdEpocaAvaliacao;
            _view.NotaInscricao = (short)inscricao.Nota;
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
            _view.IsEdit = false;
        }
        /*Regras de Negócio
          XXX 1. A primeira inscrição de um aluno numa disciplina num dado ano letivo tem de ser
          sempre para a Época de Avaliação de Frequência;
          2. Uma inscrição em Época Normal de Exame é feita automaticamente quando:
          XXXX - É lançada uma nota com valor menor que dez (10), caso em que a
          presença deve ficar com o valor “P” e o idEstadoEpoca correspondente à
          descrição “Admitido”.
          - No caso de o aluno faltar a uma época de avaliação o campo presença deve
          ser preenchido com “F” e o idEstadoEpoca automaticamente preenchido
          com o correspondente à descrição “Admitido”.
             4. Em qualquer época de avaliação, o lançamento de uma nota com valor maior ou
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
            model.IdEstadoEpoca = _view.IdEEpocaInscricao;
            model.Presenca = _view.PresencaInscricao;
            model.Nota = _view.NotaInscricao;
            // Cheka se e a primeira inscricao do aluno na UC no ano letivo e so deixa salvar se for EFRE - Epoca de Frequencia
            if (model.IdEpocaAvaliacao != "EFRE")
            {
                var inscricao = _model.GetInscricaoByAlunoAndUCAndAno(model.NumeroAluno, model.IdUnidadeCurricular, model.IdAnoLetivo);
                if (inscricao == null)
                {
                    MessageBox.Show("A primeira inscrição de um aluno numa disciplina num dado ano letivo tem de ser sempre para a Época de Avaliação de Frequência");
                    return;
                }
            }
            //Cheka se o Aluno ja foi aprovado na UC no ano letivo e nao deixa salvar
            var inscricaoAprovado = _model.GetInscricaoByAlunoAndUCAndAnoAndEstadoEpoca(model.NumeroAluno, model.IdUnidadeCurricular, model.IdAnoLetivo, 30);
            if (inscricaoAprovado != null)
            {
                MessageBox.Show("Não pode existir a inscrição numa época de avaliação subsequente a uma época de avaliação com o o idEstadoEpoca correspondente à descrição “Aprovado”.");
                return;
            }
            // Cheka se o Aluno possui uma inscricao anterior em Epoca Normal de Exame Reprovada para deixar adicionar uma Inscricao em Epoca de Avaliacao de Recurso
            if (model.IdEpocaAvaliacao == "EREC")
            {
                var inscricaoReprovado = _model.GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(model.NumeroAluno, model.IdUnidadeCurricular, model.IdAnoLetivo, 20, "ENEX");
                if (inscricaoReprovado == null)
                {
                    MessageBox.Show("A época imediatamente anterior à Época de Recurso é a Época Normal de Exame e o Aluno nao possui uma inscricao anterior em Epoca Normal de Exame Reprovada");
                    return;
                }
            }
            //Cheka se o Aluno possui uma inscricao anterior em Epoca de Avaliacao de Recurso Reprovada para deixar adicionar uma Inscricao em Epoca Especial
            if (model.IdEpocaAvaliacao == "EESP")
            {
                var inscricaoReprovado = _model.GetInscricaoByAlunoAndUCAndAnoAndEstadoEpocaAndEpocaAvaliacao(model.NumeroAluno, model.IdUnidadeCurricular, model.IdAnoLetivo, 20, "EREC");
                if (inscricaoReprovado == null)
                {
                    MessageBox.Show("A época imediatamente anterior à Época Especial é a Época de Recurso e o Aluno nao possui uma inscricao anterior em Epoca de Avaliacao de Recurso Reprovada");
                    return;
                }
            }

            // Cheka a Nota , se for menor que 10 ou a presenca for diferente de P, e for em EFRE - Epoca de Frequencia salva essa e cria uma nova inscricao automaticamente em ENEX - Epoca Normal de Exame com o idEstadoEpoca em 10 - Adimitido, mesmo numero de aluno e UC e ano letivo
            // Se a Nota for NULL deixa salvar

            try
            {
                if (model.Nota != null)
                {
                    if (model.IdEpocaAvaliacao == "EFRE" && (model.Nota < 10 || model.Presenca != "P"))
                    {
                        _model.Add(model);
                        var inscricaoENEX = new Inscricao();
                        inscricaoENEX.NumeroAluno = model.NumeroAluno;
                        inscricaoENEX.IdUnidadeCurricular = model.IdUnidadeCurricular;
                        inscricaoENEX.IdAnoLetivo = model.IdAnoLetivo;
                        inscricaoENEX.IdEpocaAvaliacao = "ENEX";
                        inscricaoENEX.IdEstadoEpoca = 10;
                        inscricaoENEX.Presenca = "";
                        inscricaoENEX.Nota = 0;
                        _model.Add(inscricaoENEX);
                        _view.Message = "Foi adicionada uma inscricao em Epoca de Exame automaticamente ao respectivo Aluno";
                    }
                    //Adiciona uma nova condicao se a nota for maior que 10 popular a presenca com P e o estado da epoca aprovado com 30 
                    else if (model.Nota >= 10)
                    {
                        model.Presenca = "P";
                        model.IdEstadoEpoca = 30;
                    }

                    else
                    {
                        if (_view.IsEdit)
                        {
                            _model.Edit(model);
                            _view.Message = "Inscrição editada com sucesso";
                        }
                        else
                        {
                            _model.Add(model);
                            _view.Message = "Inscrição adicionada com sucesso";
                        }
                        _view.IsSuccessful = true;
                        LoadInscricaoList();
                        _view.Message = "Inscrição guardada com sucesso!";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                inscricaoList = _model.GetByValue(this._view.SearchValue);
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

