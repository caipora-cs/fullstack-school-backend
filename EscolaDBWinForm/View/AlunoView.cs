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
            //Botao de fechar child container
            btn_Close.Click += delegate { this.Close(); };
        }

        private void MatchAndRaiseViewEvents()
        {
            //Associa o envento via expressao lambda, verifica se nao e nulo ? entao lanca o evento, envia o objecto this.Form e o argumento do evento como parametro
            //Associa o evento de Search via botao
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            //Associa o evento de Search via EnterKey
            tB_Search.KeyDown += (s, e) =>
            {
                //Se apertar enter no textbox de pesquisa, entao chama o evento de pesquisa
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Associa o evento de click do botao Adicionar Aluno
            btn_AddAluno.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_AlunosLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_AlunoDetalhe);
                tab_AlunoDetalhe.Text = "Adicionar Aluno";
            };
            //Associa o evento de Editar
            btn_EditAluno.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty); 
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_AlunosLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_AlunoDetalhe);
                tab_AlunoDetalhe.Text = "Editar Aluno";
            };
            //Associa o evento de Remover
            btn_DeleteAluno.Click += delegate 
            { 
                //Prompt a perguntar se deseja mesmo deletar o row
               var answer = MessageBox.Show("Tem a certeza que deseja deletar o Aluno selecionado?","Atencao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    //Se sim, entao chama o evento de delete
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    //Mostra resultado da operacao
                    MessageBox.Show(Message);
                }
            
            };
            //Associa o evento de Salvar 
            btn_Save.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                //Chekar se a operacao teve sucesso
                if (IsSuccessful)
                {
                    //Quando clickado remove a tab de detalhe
                    tabControl1.TabPages.Remove(tab_AlunoDetalhe);
                    //Quando clickado adiciona a tab de Listagem
                    tabControl1.TabPages.Add(tab_AlunosLista);
                }
                //Mostra resultado da operacao ao utilizador
                MessageBox.Show(Message);
            };
            //Associa o evento de Cancelar
            btn_Cancel.Click += delegate 
            { 
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                    //Quando clickado remove a tab de detalhe
                    tabControl1.TabPages.Remove(tab_AlunoDetalhe);
                    //Quando clickado adiciona a tab de Listagem
                    tabControl1.TabPages.Add(tab_AlunosLista);
            };
            

        }

        //Propriedades
        public int NumeroAluno { get => (int)numUpD_NumeroAluno.Value; set => numUpD_NumeroAluno.Value = value; } //Sem set porque o valor é gerado automaticamente,TODO:Migrar propriedade autoincrement no Numero do Aluno Field
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

        //Single Page enforcer: Abre um form apenas.
        private static AlunoView instance;
        //Metodo aceita um parent container para ser instanciado em MDI single page 
        public static AlunoView GetInstance(Form parentContainer)
        {
            //Checka se a view esta fechada e cria uma nova view
            if (instance == null || instance.IsDisposed)
            {
                instance = new AlunoView();
                instance.MdiParent = parentContainer;
                //Retira as bordas
                instance.FormBorderStyle = FormBorderStyle.None;
                //Prenche o contianer inteiro
                instance.Dock = DockStyle.Fill;
            }
            else
            {   
                //Se estiver Minimizada traz a frente
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                //Se estiver aberta traz a frente
                instance.BringToFront();
            }
            return instance;
        }

    }
}
