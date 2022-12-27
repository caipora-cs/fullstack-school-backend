using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        //MVC - Dependency injection one o controller aceita o frontend(view) e o backend(model) e faz a ligacao de ambos. 
        //Esse design pattern ajuda a manter a modularidade do codebase para futuras updates, e reusabilidade para outros componentes.
        
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
            //Liga o BindingSource ao Model - Cria uma biding entre o Controller de Data e o Source da Data
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
            ClearView();
        }

        private void SaveAluno(object? sender, EventArgs e)
        {
            //Cria uma nova instancia de Aluno e associa os valores do View ao Model
            var model = new Aluno();
            model.Numero = _view.NumeroAluno;
            model.NomeProprio = _view.NomeAluno;
            model.Apelido = _view.ApelidoAluno;
            model.DataNascimento = _view.IdadeAluno;
            model.Morada = _view.MoradaAluno;
            model.Email = _view.EmailAluno;
            model.Telefone = _view.TelefoneAluno;
            model.ReferenciaCurso = Convert.ToInt32(_view.CursoAluno);
            //Apanha os possiveis Erros da operacao - sempre que houver ligacao direta de ir ou vir da DB convem ouvir os erros
            try
            {
                //Valida toda a data antes de enviar para a DB
                new ModelDataValidation().ValidateModelData(model);
                //Verifica se o estado do View e de Editar ou Adicionar
                if (_view.IsEdit)
                {
                    //Edita o aluno
                    _model.Edit(model);
                    _view.Message = "Aluno editado com sucesso!";
                }
                else
                {
                    //Adiciona o aluno
                    _model.Add(model);
                    _view.Message = "Aluno adicionado com sucesso!";
                }
                //Atualiza a lista de alunos
                LoadAlunosList();
                //Limpa o View
                ClearView();
                //Mostra a mensagem de sucesso
                _view.Message = "Aluno guardado com sucesso!";
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Mostra a mensagem de erro e falha
                _view.Message = ex.Message;
                _view.IsSuccessful = false;
            }
        }

        //Limpa os dados do View
        private void ClearView()
        {
            _view.NumeroAluno = 0;
            _view.NomeAluno = "";
            _view.ApelidoAluno = "";
            _view.IdadeAluno = DateTime.Now;
            _view.MoradaAluno = "";
            _view.EmailAluno = "";
            _view.TelefoneAluno = "";
            _view.CursoAluno = "";
        }

        private void DeleteSelectedAluno(object? sender, EventArgs e)
        {
            try
            {
                //Apanha o model
                var aluno = (Aluno)alunosBindingSource.Current;
                //Chama o delete method no numero do aluno
                _model.Delete(aluno.Numero);
                //Faz as alteracoes e mostra as messagems necessarias ao utilizador
                _view.IsSuccessful = true;
                _view.Message = "Aluno apagado.";
                //Reload Lista
                LoadAlunosList();
            }
            catch (Exception ex)
            {
                _view.Message = "Erro ao apagar aluno.";
                _view.IsSuccessful = false;
            }
        }

        private void LoadSelectedToEditAluno(object? sender, EventArgs e)
        {
            //Seleciona a linha do DataGridView e o objeto de data por baixo
            var aluno = (Aluno)alunosBindingSource.Current;
            //Apos selecionado, corresponde a data as textboxes da view
            _view.NumeroAluno = aluno.Numero;
            _view.NomeAluno = aluno.NomeProprio;
            _view.ApelidoAluno = aluno.Apelido;
            _view.IdadeAluno = aluno.DataNascimento;
            _view.MoradaAluno = aluno.Morada;
            _view.EmailAluno = aluno.Email;
            _view.TelefoneAluno = aluno.Telefone;
            _view.CursoAluno = aluno.ReferenciaCurso.ToString();
            //_view.AnoCursoAluno = aluno.AnoCurso; <== Buscar data da ultima Inscricao Type:Datetime
            //Adicionar Foto e PictureBox
            //IsEdit diz se algo foi mudado ou nao para que o SaveEvent saiba se e para adicionar ou editar
            _view.IsEdit = true;
        }

        private void AddNewAluno(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
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
