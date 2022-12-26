using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm.Controller
{
    public class AlunoController
    {
        //Fields
        private IAlunoView _view;
        private IAluno _model;
        private BindingSource alunosBindingSource;
        private IEnumerable<Aluno> alunoList;

        public AlunoController(IAlunoView view, IAluno model)
        {
            //Liga os eventos do View ao Controller Methods
            this.alunosBindingSource = new BindingSource();
            this._view = view;
            this._model = model;
            this._view.SearchEvent += SearchAluno;
            this._view.AddNewEvent += AddNewAluno;
            this._view.EditEvent += LoadSelectedToEditAluno;
            this._view.DeleteEvent += DeleteSelectedAluno;
            this._view.SaveEvent += SaveAluno;
            this._view.CancelEvent += CancelAction;
            //Liga o BindingSource ao Model
            this._view.SetAlunoListBindingSource(alunosBindingSource); //Liga a data source do DataGridView componente aos dados do BindingSource Alunos
            //Carrega a lista de alunos no View
            LoadAlunosList();
            //Mostra o View
            this._view.Show();
        }
        
        //Metodos
        private void LoadAlunosList()
        {
            alunoList = _model.GetAll();
            alunosBindingSource.DataSource = alunoList; //Update automatico sempre que data source muda
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveAluno(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedAluno(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedToEditAluno(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewAluno(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchAluno(object? sender, EventArgs e)
        {
            //Checka se o campo de pesquisa esta vazio 
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
            {
                //Pesquisa por valor
                alunoList = _model.GetByValue(this._view.SearchValue);
                //Update da lista de alunos
                alunosBindingSource.DataSource = alunoList;
            }
            else
            {
                //Carrega a lista de alunos no View
                LoadAlunosList();
            }
        }
    }
}
