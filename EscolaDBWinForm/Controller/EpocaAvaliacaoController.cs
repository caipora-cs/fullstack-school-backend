using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm.Controller
{
    internal class EpocaAvaliacaoController
    {
        private IEpocaAvaliacaoView _view;
        private IEpocaAvaliacao _model;
        private BindingSource epocaaBindingSource;
        private IEnumerable<EpocaAvaliacao> epocaaList;

        public EpocaAvaliacaoController(IEpocaAvaliacaoView view, IEpocaAvaliacao model)
        {
            _view = view;
            _model = model;
            epocaaBindingSource = new BindingSource();
            epocaaList = new List<EpocaAvaliacao>();
            //Eventos
            _view.SearchEvent += SearchEpocaA;
            _view.AddNewEvent += AddNewEpocaA;
            _view.EditEvent += LoadSelectedtoEditEpocaA;
            _view.DeleteEvent += DeleteEpocaA;
            _view.SaveEvent += SaveEpocaA;
            _view.CancelEvent += CancelAction;

            _view.SetEpocaAListBindingSource(epocaaBindingSource);

            LoadEpocaAList();
            _view.Show();
        }

        private void LoadEpocaAList()
        {
            epocaaList = _model.GetAll();
            epocaaBindingSource.DataSource = epocaaList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveEpocaA(object? sender, EventArgs e)
        {
            var model = new EpocaAvaliacao();
            model.Id = _view.IdEpocaA;
            model.Descricao = _view.DescricaoEpocaA;

            try
            {
                new ModelDataValidation().ValidateModelData(model);
                if (_view.IsEdit)
                {
                    _model.Edit(model);
                    _view.Message = "Epoca de Avaliacao actualizada com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Epoca de Avaliacao adicionada com sucesso!";
                }

                _view.IsSuccessful = true;
                LoadEpocaAList();
                _view.Message = "Epoca de Avaliacao guardada com sucesso!";
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
            finally
            {
                ClearView();
            }
        }

        private void ClearView()
        {
            //get the last entered Id(string) convert to int and add 1 and convert back to string
            _view.IdEpocaA = "";
            _view.DescricaoEpocaA = string.Empty;
        }

        private void DeleteEpocaA(object? sender, EventArgs e)
        {
            try
            {
                var epoca_a = (EpocaAvaliacao)epocaaBindingSource.Current;
                _model.Delete(epoca_a.Id);
                _view.Message = "Epoca de Avaliacao eliminada com sucesso!";
                _view.IsSuccessful = true;
                LoadEpocaAList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
            finally
            {
                ClearView();
            }
        }

        private void LoadSelectedtoEditEpocaA(object? sender, EventArgs e)
        {
            var epoca_a = (EpocaAvaliacao)epocaaBindingSource.Current;
            _view.IdEpocaA = epoca_a.Id;
            _view.DescricaoEpocaA = epoca_a.Descricao;
            _view.IsEdit = true;
        }

        private void AddNewEpocaA(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchEpocaA(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                epocaaList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                epocaaBindingSource.DataSource = epocaaList;
            }
            else
            {
                //Carrega a lista no View
                LoadEpocaAList();
            }
        }


    }
}
