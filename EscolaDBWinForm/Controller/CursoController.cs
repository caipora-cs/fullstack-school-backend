using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm.Controller
{
    internal class CursoController
    {
        private ICursoView _view;
        private ICurso _model;
        private BindingSource cursosBindingSource;
        private BindingSource ucfromcursosBindingSource;
        private IEnumerable<Curso> cursoList;
        private ICollection<UnidadeCurricular> ucList;

        public CursoController(ICursoView view, ICurso model)
        {
            _view = view;
            _model = model;
            cursosBindingSource = new BindingSource();
            ucfromcursosBindingSource = new BindingSource();
            cursoList = new List<Curso>();
            ucList = new List<UnidadeCurricular>();

            //Events
            _view.SearchEvent += SearchCurso;
            _view.AddNewEvent += AddNewCurso;
            _view.EditEvent += LoadSelectedtoEditCurso;
            _view.DeleteEvent += DeleteCurso;
            _view.SaveEvent += SaveCurso;
            _view.CancelEvent += CancelAction;
            _view.SelectEvent += SelectAction;

            //Liga BindingSource para as GridViews
            _view.SetCursoListBindingSource(cursosBindingSource);
            _view.SetUnidadeCurricularListBindingSource(ucfromcursosBindingSource);

            LoadCursosList();
            _view.Show();
        }

        private void SelectAction(object? sender, EventArgs e)
        {
            //Ao selecionar um curso na gridview, mostra suas UCs na segunda gridview utilizando o metodo GetUCs(int id)
            //Evitar null type aqui devido a exceptions

            var model = (Curso)cursosBindingSource.Current;
            if (model != null)
            {
                ucList = _model.GetUCs(model.Referencia);
                ucfromcursosBindingSource.DataSource = ucList;
            }
        }

        private void LoadCursosList()
        {
            cursoList = _model.GetAll();
            cursosBindingSource.DataSource = cursoList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveCurso(object? sender, EventArgs e)
        {
            //Cria uma nova instancia de Curso e associa os valores do View ao Model
            var model = new Curso();
            model.Referencia = _view.ReferenciaCurso;
            model.Nome = _view.NomeCurso;
            model.Sigla = _view.SiglaCurso;
            model.DataInicio = _view.DataInicioCurso;

            //Apanha os possiveis Erros da operacao - sempre que houver ligacao direta de ir ou vir da DB convem ouvir os erros
            try
            {
                //Valida toda a data antes de enviar para a DB
                new ModelDataValidation().ValidateModelData(model);
                //Verifica se o estado do View e de Editar ou Adicionar
                if (_view.IsEdit)
                {
                    //Edita o curso
                    _model.Edit(model);
                    _view.Message = "Curso editado com sucesso!";
                }
                else
                {
                    //Adiciona o curso
                    _model.Add(model);
                    _view.Message = "Curso adicionado com sucesso!";
                }
                //Atualiza a lista de curso
                LoadCursosList();
                //Limpa o View
                ClearView();
                //Mostra a mensagem de sucesso
                _view.Message = "Curso guardado com sucesso!";
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Mostra a mensagem de erro e falha
                _view.Message = ex.Message;
                _view.IsSuccessful = false;
            }

        }

        private void ClearView()
        {

            //Apanha o Numero de Curso do ultimo curso adicionado e incrementa 1
            var modelCurso = _model.GetAll().LastOrDefault()?.Referencia + 1 ?? 1;
            _view.ReferenciaCurso = modelCurso;
            //Defaults
            _view.NomeCurso = string.Empty;
            _view.SiglaCurso = string.Empty;
            _view.DataInicioCurso = DateTime.Now;
            _view.IsEdit = false;
        }

        private void DeleteCurso(object? sender, EventArgs e)
        {
            //Apanha os possiveis Erros da operacao - sempre que houver ligacao direta de ir ou vir da DB convem ouvir os erros
            try
            {
                //Apanha o curso selecionado no View
                var curso = (Curso)cursosBindingSource.Current;

                //Remove o curso
                _model.Delete(curso.Referencia);
                //Mostra a mensagem de sucesso
                _view.Message = "Curso removido com sucesso!";
                _view.IsSuccessful = true;
                //Atualiza a lista de curso
                LoadCursosList();
                //Limpa o View
                ClearView();

            }
            catch (Exception ex)
            {
                //Mostra a mensagem de erro e falha
                _view.Message = "Erro ao apagar Curso";
                _view.IsSuccessful = false;
            }
        }

        private void LoadSelectedtoEditCurso(object? sender, EventArgs e)
        {
            //Apanha o curso selecionado no View
            var curso = (Curso)cursosBindingSource.Current;
            //Atribui os valores do curso selecionado ao View
            _view.ReferenciaCurso = curso.Referencia;
            _view.NomeCurso = curso.Nome;
            _view.SiglaCurso = curso.Sigla;
            _view.DataInicioCurso = curso.DataInicio;
            _view.IsEdit = true;
        }

        private void AddNewCurso(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchCurso(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                cursoList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                cursosBindingSource.DataSource = cursoList;
            }
            else
            {
                //Carrega a lista no View
                LoadCursosList();
            }
        }

    }


}


