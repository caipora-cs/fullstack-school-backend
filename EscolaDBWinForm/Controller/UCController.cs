using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Controller
{
    internal class UCController
    {
        private IUCView _view;
        private IUnidadeCurricular _model;
        private BindingSource ucBindingSource;
        private IEnumerable<UnidadeCurricular> ucList;


        public UCController(IUCView view, IUnidadeCurricular model)
        {
            _view = view;
            _model = model;
            ucBindingSource = new BindingSource();
            ucList = new List<UnidadeCurricular>();

            //Eventos
            _view.SearchEvent += SearchUC;
            _view.AddNewEvent += AddNewUC;
            _view.EditEvent += LoadSelectedtoEditUC;
            _view.DeleteEvent += DeleteUC;
            _view.SaveEvent += SaveUC;
            _view.CancelEvent += CancelAction;

            //Liga BindingSourc
            _view.SetUCListBindingSource(ucBindingSource);

            LoadUCList();
            _view.Show();
        }

        private void LoadUCList()
        {
            ucList = _model.GetAll();
            ucBindingSource.DataSource = ucList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveUC(object sender, EventArgs e)
        {
            //Cria uma nova instancia de UC e associa os valores do View ao Model
            var model = new UnidadeCurricular();
            model.Id = Convert.ToInt32(_view.IdUC);
            model.ReferenciaCurso = Convert.ToInt32(_view.ReferenciaCursoUC);
            model.NumeroDocente = Convert.ToInt32(_view.NumeroDocenteUC);
            model.Nome = _view.NomeUC;
            model.Sigla = _view.SiglaUC;
            model.Creditos = Convert.ToDecimal(_view.CreditosUC);
            model.Ano = _view.AnoUC;
            model.Semestre = _view.SemestreUC;

            //Apanha os possiveis Erros da operacao - sempre que houver ligacao direta de ir ou vir da DB convem ouvir os erros
            try
            {
                new ModelDataValidation().ValidateModelData(model);
                if (_view.IsEdit)
                {
                    _model.Edit(model);
                    _view.Message = "Unidade Curricular editada com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Unidade Curricular adicionada com sucesso!";
                }
                LoadUCList();
                ClearView();
                _view.IsSuccessful = true;
                _view.Message = "Operação realizada com sucesso!";
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }

        }

        private void ClearView()
        {
            var modelUC = _model.GetAll().LastOrDefault()?.Id + 1 ?? 1;
            _view.IdUC = modelUC;
            _view.ReferenciaCursoUC = 0;
            _view.NumeroDocenteUC = 0;
            _view.NomeUC = "";
            _view.SiglaUC = "";
            _view.CreditosUC = 0;
            _view.AnoUC = "";
            _view.SemestreUC = "";
            _view.IsEdit = false;
        }

        private void DeleteUC(object? sender, EventArgs e)
        {
            try
            {
                var uc = (UnidadeCurricular)ucBindingSource.Current;
                _model.Delete(uc.Id);
                _view.Message = "Unidade Curricular eliminada com sucesso!";
                _view.IsSuccessful = true;
                LoadUCList();
                ClearView();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "Erro ao apagar Unidade Curricular";
            }
        }

        private void LoadSelectedtoEditUC(object? sender, EventArgs e)
        {
            var uc = (UnidadeCurricular)ucBindingSource.Current;
            _view.IdUC = uc.Id;
            _view.ReferenciaCursoUC = uc.ReferenciaCurso;
            _view.NumeroDocenteUC = uc.NumeroDocente;
            _view.NomeUC = uc.Nome;
            _view.SiglaUC = uc.Sigla;
            _view.CreditosUC = uc.Creditos;
            _view.AnoUC = uc.Ano;
            _view.SemestreUC = uc.Semestre;
            _view.IsEdit = true;
        }

        private void AddNewUC(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchUC(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                ucList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                ucBindingSource.DataSource = ucList;
            }
            else
            {
                //Carrega a lista  no View
                LoadUCList();
            }


        }
    }
}


