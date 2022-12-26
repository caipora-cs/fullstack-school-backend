using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaDBWinForm.View
{
    public partial class AlunoView : Form , IAlunoView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public AlunoView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            //Esconde a segunda tab. So deve ser mostrada quando o utilizador clicar no botao Editar ou Adicionar
            tabControl1.TabPages.Remove(tab_AlunoDetalhe);
        }

        private void MatchAndRaiseViewEvents()
        {
            //Associa o envento via expressao lambda, verifica se nao e nulo ? entao lanca o evento, envia o objecto this.Form e o argumento do evento como parametro
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tB_Search.KeyDown += (s, e) =>
            {
                //Se apertar enter no textbox de pesquisa, entao chama o evento de pesquisa
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }

        //Propriedades
        public int NumeroAluno { get => (int)numUpD_NumeroAluno.Value; } //Sem set porque o valor é gerado automaticamente,TODO:Migrar propriedade autoincrement no Numero do Aluno Field
        public string NomeAluno { get => tb_NomeAluno.Text; set => tb_NomeAluno.Text = value; }
        public string ApelidoAluno { get => tb_Apelido.Text; set => tb_Apelido.Text = value; }
        public DateTime IdadeAluno { get => dTimeP_DataNascimento.Value; set => dTimeP_DataNascimento.Value = value; }
        public string MoradaAluno { get => tb_Morada.Text; set => tb_Morada.Text = value; }
        public string EmailAluno { get => tb_Email.Text ; set => tb_Email.Text = value; }
        public string TelefoneAluno { get => tb_Telefone.Text; set => tb_Telefone.Text = value; }
        public string CursoAluno { get => tb_Curso.Text; set => tb_Curso.Text = value; }
        public DateTime AnoCursoAluno { get => dTimeP_AnoCurso.Value; set => dTimeP_AnoCurso.Value = value; }
        public string SearchValue { get =>  tB_Search.Text; set => tB_Search.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        //Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Metodos
        public void SetAlunoListBindingSource(BindingSource alunoList)
        {
            dgv_Alunos.DataSource = alunoList;
        }
    }
}
