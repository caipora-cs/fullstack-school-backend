using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm.Controller
{
    internal class EstadoEpocaController
    {
        private IEstadoEpocaView _view;
        private IEstadoEpoca _model;
        private BindingSource eepocaBindingSource;
        private IEnumerable<EstadoEpoca> eepocaList;
        //private ICollection<Inscricao> inscricaoList;

        public EstadoEpocaController(IEstadoEpocaView view, IEstadoEpoca model)
        {
            _view = view;
            _model = model;
            eepocaBindingSource = new BindingSource();
            eepocaList = new List<EstadoEpoca>();
            //inscricaoList = new List<Inscricao>();

            //Eventos
            _view.SearchEvent += SearchEEpoca;
            _view.AddNewEvent += AddNewEEpoca;
            _view.EditEvent += LoadSelectedtoEditEEpoca;
            _view.DeleteEvent += DeleteEEpoca;
            _view.SaveEvent += SaveEEpoca;
            _view.CancelEvent += CancelAction;

            //Liga BindingSource para as GridViews
            _view.SetEEpocaListBindingSource(eepocaBindingSource);

            LoadEEpocaList();
            _view.Show();
        }


        private void LoadEEpocaList()
        {
            eepocaList = _model.GetAll();
            eepocaBindingSource.DataSource = eepocaList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveEEpoca(object? sender, EventArgs e)
        {
            var model = new EstadoEpoca();
            model.Id = _view.IdEEpoca;
            model.Descricao = _view.DescricaoEEpoca;

            try
            {
                if (_view.IsEdit)
                {
                    _model.Edit(model);
                    _view.Message = "Estado de Epoca atualizado com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Estado de Epoca adicionado com sucesso!";
                }
                _view.IsSuccessful = true;
                LoadEEpocaList();
                _view.Message = "Estado de Epoca guardado com sucesso!";
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

        private void ClearView()
        {
            var modelEEpoca = _model.GetAll().LastOrDefault()?.Id + 1 ?? 1;
            _view.IdEEpoca = (short)modelEEpoca;
            _view.DescricaoEEpoca = "";
            _view.IsEdit = false;
        }

        private void DeleteEEpoca(object? sender, EventArgs e)
        {
            try
            {
                var e_epoca = (EstadoEpoca)eepocaBindingSource.Current;
                _model.Delete(e_epoca.Id);
                _view.IsSuccessful = true;
                _view.Message = "Estado de Epoca eliminado com sucesso!";
            }
            catch (Exception ex)
            {
                _view.Message = "Erro ao eliminar Estado de Epoca";
                _view.IsSuccessful = false;
            }
            finally
            {
                LoadEEpocaList();
                ClearView();
            }
        }

        private void LoadSelectedtoEditEEpoca(object? sender, EventArgs e)
        {
            var e_epoca = (EstadoEpoca)eepocaBindingSource.Current;
            _view.IdEEpoca = e_epoca.Id;
            _view.DescricaoEEpoca = e_epoca.Descricao;
            _view.IsEdit = true;
        }

        private void AddNewEEpoca(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchEEpoca(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                eepocaList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                eepocaBindingSource.DataSource = eepocaList;
            }
            else
            {
                //Carrega a lista no View
                LoadEEpocaList();
            }
        }


    }
}
