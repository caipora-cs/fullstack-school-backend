using EscolaDBWinForm.Models;
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
    public partial class CursoView : Form, ICursoView
    {
        //Propriedades
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public CursoView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_CursoDetalhe);
            btn_Close.Click += delegate { this.Close(); };
        }

        private void MatchAndRaiseViewEvents()
        {
            //Associa o envento via expressao lambda, verifica se nao e nulo ? entao lanca o evento, envia o objecto this.Form e o argumento do evento como parametro
            //Associa o evento de Search via botao
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            //Associa o evento de Search via EnterKey
            tb_Search.KeyDown += (s, e) =>
            {
                //Se apertar enter no textbox de pesquisa, entao chama o evento de pesquisa
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Associa o evento de click do botao Adicionar Curso
            btn_AddCurso.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_CursoLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_CursoDetalhe);
                tab_CursoDetalhe.Text = "Adicionar Curso";
            };
            //Associa o evento de Editar
            btn_EditCurso.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_CursoLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_CursoDetalhe);
                tab_CursoDetalhe.Text = "Editar Curso";
            };
            //Associa o evento de click do botao Cancelar
            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de detalhe
                tabControl1.TabPages.Remove(tab_CursoDetalhe);
                //Quando clickado adiciona a tab de Listagem
                tabControl1.TabPages.Add(tab_CursoLista);
            };
            //Associa o evento de click do botao Guardar
            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    //Quando clickado remove a tab de detalhe
                    tabControl1.TabPages.Remove(tab_CursoDetalhe);
                    //Quando clickado adiciona a tab de Listagem
                    tabControl1.TabPages.Add(tab_CursoLista);
                }
                MessageBox.Show(Message);
            };

            //Associa o evento de click do botao Eliminar
            btn_DeleteCurso.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                var answer = MessageBox.Show("Tem a certeza que deseja deletar o Curso selecionado?","Atencao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    //Se sim, entao chama o evento de delete
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    //Mostra resultado da operacao
                    MessageBox.Show(Message);
                }
 
            };

        }
                  


    //Propriedades
    public string ReferenciaCurso
        {
            get { return tb_Referencia.Text; }
            set { tb_Referencia.Text = value; }
        }
        public string NomeCurso
        {
            get { return tb_NomeCurso.Text; }
            set { tb_NomeCurso.Text = value; }
        }
        public string SiglaCurso
        {
            get { return tb_SiglaCurso.Text; }
            set { tb_SiglaCurso.Text = value; }
        }
        public DateTime DataInicioCurso
        {
            get { return dTimeP_DataInicioCurso.Value; }
            set { dTimeP_DataInicioCurso.Value = value; }
        }
        public ICollection<UnidadeCurricular> UnidadeCurricularCurso
        {
            get { return (ICollection<UnidadeCurricular>)dgView_UC.DataSource; }
            set { dgView_UC.DataSource = value; }
        }

        //State
        public string SearchValue
        {
            get { return tb_Search.Text; }
            set { tb_Search.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Events - Acoes do Utilizador
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Metodos 
        public void SetCursoListBindingSource(BindingSource cursoList)
        {
            dgView_CursosLista.DataSource = cursoList;
        }
        
        //Single Page enforcer: Abre um form apenas.
        private static CursoView instance;
        //Metodo aceita um parent container para ser instanciado em MDI single page 
        public static CursoView GetInstance(Form parentContainer)
        {
            //Checka se a view esta fechada e cria uma nova view
            if (instance == null || instance.IsDisposed)
            {
                instance = new CursoView();
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







        
    

