using EscolaDBWinForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.Data;

namespace EscolaDBWinForm.Controller
{
    internal class DocenteController
    {
        private IDocenteView _view;
        private IDocente _model;
        private BindingSource docenteBindingSource;
        private BindingSource ucBindingSource;
        private IEnumerable<Docente> docenteList;
        private ICollection<UnidadeCurricular> ucList;

        public DocenteController(IDocenteView view, IDocente model)
        {
            _view = view;
            _model = model;
            docenteBindingSource = new BindingSource();
            ucBindingSource = new BindingSource();
            docenteList = new List<Docente>();
            ucList = new List<UnidadeCurricular>();
            //Eventos
            _view.SearchEvent += SearchDocente;
            _view.AddNewEvent += AddNewDocente;
            _view.EditEvent += LoadSelectedtoEditDocente;
            _view.DeleteEvent += DeleteDocente;
            _view.SaveEvent += SaveDocente;
            _view.CancelEvent += CancelAction;
            _view.SelectEvent += SelectAction;

            //Liga BindingSource para as GridViews
            _view.SetDocenteListBindingSource(docenteBindingSource);
            _view.SetUnidadeCurricularListBindingSource(ucBindingSource);

            LoadDocenteList();
            _view.Show();
        }

        private void SelectAction(object? sender, EventArgs e)
        {
            //Ao selecionar um docente na gridview, mostra suas UCs na segunda gridview utilizando o metodo GetUCs(int id)
            //Evitar null type aqui devido a exceptions

            var model = (Docente)docenteBindingSource.Current;
            if (model != null)
            {
                ucList = _model.GetUCs(model.Numero);
                ucBindingSource.DataSource = ucList;
            }
        }

        private void LoadDocenteList()
        {
            docenteList = _model.GetAll();
            docenteBindingSource.DataSource = docenteList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            ClearView();
        }

        private void SaveDocente(object? sender, EventArgs e)
        {
            var model = new Docente();
            model.Numero = _view.NumeroDocente;
            model.NomeProprio = _view.NomeDocente;
            model.Email = _view.EmailDocente;
            model.Telefone = _view.TelefoneDocente;
            model.Apelido = _view.ApelidoDocente;
            model.DataNascimento = _view.DataNascimentoDocente;
            model.Extensao = _view.ExtensaoDocente;
            model.Salario = _view.SalarioDocente;

            try
            {
                new ModelDataValidation().ValidateModelData(model);
                if (_view.IsEdit)
                {
                    _model.Edit(model);
                    _view.Message = "Docente editado com sucesso!";
                }
                else
                {
                    _model.Add(model);
                    _view.Message = "Docente adicionado com sucesso!";
                }
                LoadDocenteList();
                ClearView();
                _view.IsSuccessful = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _view.IsSuccessful = false;
            }
        }

        private void ClearView()
        {
            _view.NumeroDocente = 0;
            _view.NomeDocente = "";
            _view.ApelidoDocente = "";
            _view.DataNascimentoDocente = null;
            _view.EmailDocente = "";
            _view.TelefoneDocente = "";
            _view.ExtensaoDocente = "";
            _view.SalarioDocente = 0;
            _view.IsEdit = false;
        }

        private void DeleteDocente(object? sender, EventArgs e)
        {
            //Apanha os possiveis Erros da operacao - sempre que houver ligacao direta de ir ou vir da DB convem ouvir os erros
            try
            {
                //Apanha o curso selecionado no View
                var docente = (Docente)docenteBindingSource.Current;

                //Remove o curso
                _model.Delete(docente.Numero);
                //Mostra a mensagem de sucesso
                _view.Message = "Docente removido com sucesso!";
                _view.IsSuccessful = true;
                //Atualiza a lista de curso
                LoadDocenteList();
                //Limpa o View
                ClearView();

            }
            catch (Exception ex)
            {
                //Mostra a mensagem de erro e falha
                _view.Message = "Erro ao apagar Docente";
                _view.IsSuccessful = false;
            }
        }

        private void LoadSelectedtoEditDocente(object? sender, EventArgs e)
        {
            //Apanha o curso selecionado no View
            var docente = (Docente)docenteBindingSource.Current;
            //Carrega os dados do curso selecionado no View
            _view.NumeroDocente = docente.Numero;
            _view.NomeDocente = docente.NomeProprio;
            _view.ApelidoDocente = docente.Apelido;
            _view.DataNascimentoDocente = docente.DataNascimento;
            _view.EmailDocente = docente.Email;
            _view.TelefoneDocente = docente.Telefone;
            _view.ExtensaoDocente = docente.Extensao;
            _view.SalarioDocente = docente.Salario;
            _view.IsEdit = true;
        }

        private void AddNewDocente(object? sender, EventArgs e)
        {
            ClearView();
            _view.IsEdit = false;
        }

        private void SearchDocente(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                docenteList = _model.GetByValue(this._view.SearchValue);
                //Update da lista 
                docenteBindingSource.DataSource = docenteList;
            }
            else
            {
                //Carrega a lista no View
                LoadDocenteList();
            }
        }

    }
}

