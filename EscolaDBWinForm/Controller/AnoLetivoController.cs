using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm.Controller
{
    internal class AnoLetivoController
    {
        private IAnoLetivoView _view;
        private IAnoLetivo _model;
        private BindingSource anoBindingSource;
        private BindingSource inscricaoBindingSource;
        private IEnumerable<AnoLetivo> anoList;
        private ICollection<Inscricao> inscricaoList;

        public AnoLetivoController(IAnoLetivoView view, IAnoLetivo model)
        {
            _view = view;
            _model = model;
            anoBindingSource = new BindingSource();
            inscricaoBindingSource = new BindingSource();
            anoList = new List<AnoLetivo>();
            inscricaoList = new List<Inscricao>();

            //Eventos
            _view.SearchEvent += SearchAno;
            _view.AddNewEvent += AddNewAno;
            _view.EditEvent += LoadSelectedtoEditAno;
            _view.DeleteEvent += DeleteAno;
            _view.SaveEvent += SaveAno;
            _view.CancelEvent += CancelAction;
            _view.SelectEvent += LoadSelectedInscricao;

            //Liga BindingSource para as GridViews
            _view.SetAnoLetivoListBindingSource(anoBindingSource);
            _view.SetInscricaoListBindingSource(inscricaoBindingSource);

            LoadAnoList();
            _view.Show();
        }

        private void LoadSelectedInscricao(object? sender, EventArgs e)
        {
            var model = (AnoLetivo)anoBindingSource.Current;
            if (model != null)
            {
                inscricaoList = _model.GetInscricao(model.Id);
                inscricaoBindingSource.DataSource = inscricaoList;
            }
        }

        private void LoadAnoList()
        {
            anoList = _model.GetAll();
            anoBindingSource.DataSource = anoList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveAno(object? sender, EventArgs e)
        {
            var model = new AnoLetivo();
            model.Id = _view.IdAno;
            model.AnoInicial = _view.AnoLetivoInicial;
            model.AnoFinal = _view.AnoLetivoFinal;

            try
            {
                if (model.Id == 0)
                {
                    _model.Edit(model);
                    _view.Message = "Ano Letivo atualizado com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Ano Letivo adicionado com sucesso!";
                }
                _view.IsSuccessful = true;
                LoadAnoList();
                _view.Message = "Ano Letivo guardado com sucesso!";
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
            var modelAno = _model.GetAll().LastOrDefault()?.Id + 1 ?? 1;
            _view.IdAno = (short)modelAno;
            _view.AnoLetivoInicial = 0;
            _view.AnoLetivoFinal = 0;
        }

        private void DeleteAno(object? sender, EventArgs e)
        {
            try
            {
                var ano = (AnoLetivo)anoBindingSource.Current;
                _model.Delete(ano.Id);
                _view.IsSuccessful = true;
                _view.Message = "Ano eliminado com sucesso!";
            }
            catch (Exception ex)
            {
                _view.Message = "Erro ao eliminar Ano";
                _view.IsSuccessful = false;
            }
            finally
            {
                LoadAnoList();
                ClearView();
            }
        }

        private void LoadSelectedtoEditAno(object? sender, EventArgs e)
        {
            var ano = (AnoLetivo)anoBindingSource.Current;
            _view.IdAno = ano.Id;
            _view.AnoLetivoInicial = ano.AnoInicial;
            _view.AnoLetivoFinal = ano.AnoFinal;
        }

        private void AddNewAno(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchAno(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                anoList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                anoBindingSource.DataSource = anoList;
            }
            else
            {
                //Carrega a lista no View
                LoadAnoList();
            }
        }


    }
}
