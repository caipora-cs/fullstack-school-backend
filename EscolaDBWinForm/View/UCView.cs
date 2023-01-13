using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaDBWinForm.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EscolaDBWinForm.View
{
    public partial class UCView : Form, IUCView
    {
        //Propriedades
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public UCView()
        {
            InitializeComponent();
            MatchAndRaiseEvents();
            tabControl1.TabPages.Remove(tab_UCDetalhe);
            btn_Close.Click += delegate { this.Close(); };
        }

        private void MatchAndRaiseEvents()
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
            btn_AddUC.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_UCLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_UCDetalhe);
                tab_UCDetalhe.Text = "Adicionar UC";
            };
            //Associa o evento de Editar
            btn_EditUC.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de Listagem
                tabControl1.TabPages.Remove(tab_UCLista);
                //Quando clickado adiciona a tab de detalhe
                tabControl1.TabPages.Add(tab_UCDetalhe);
                tab_UCDetalhe.Text = "Editar UC";
            };
            //Associa o evento de Cancelar
            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                //Quando clickado remove a tab de detalhe
                tabControl1.TabPages.Remove(tab_UCDetalhe);
                //Quando clickado adiciona a tab de Listagem
                tabControl1.TabPages.Add(tab_UCLista);
            };
            //Associa o evento de Salvar
            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    //Quando clickado remove a tab de detalhe
                    tabControl1.TabPages.Remove(tab_UCDetalhe);
                    //Quando clickado adiciona a tab de Listagem
                    tabControl1.TabPages.Add(tab_UCLista);
                }
                MessageBox.Show(Message);
            };

            btn_DeleteUC.Click += delegate
            {
                var answer = MessageBox.Show("Tem a certeza que pretende eliminar a Unidade Curricular selecionado?", "Eliminar Unidade Curricular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };


        }

        //Propriedades
        public int IdUC
        {
            get { return Convert.ToInt32(tb_Id.Text); }
            set { tb_Id.Text = value.ToString(); }
        }

        public int ReferenciaCursoUC
        {
            get { return Convert.ToInt32(tb_ReferenciaCurso.Text); }
            set { tb_ReferenciaCurso.Text = value.ToString(); }
        }

        public int NumeroDocenteUC
        {
            get { return Convert.ToInt32(tb_NumeroDocente.Text); }
            set { tb_NumeroDocente.Text = value.ToString(); }
        }

        public string NomeUC
        {
            get { return tb_NomeUC.Text; }
            set { tb_NomeUC.Text = value; }
        }

        public string SiglaUC
        {
            get { return tb_SiglaUC.Text; }
            set { tb_SiglaUC.Text = value; }
        }

        public decimal CreditosUC
        {
            get { return Convert.ToDecimal(tb_Creditos.Text); }
            set { tb_Creditos.Text = value.ToString(); }
        }

        public string AnoUC
        {
            get { return tb_AnoUC.Text; }
            set { tb_AnoUC.Text = value; }
        }

        public string SemestreUC
        {
            get { return tb_SemestreUC.Text; }
            set { tb_SemestreUC.Text = value; }
        }

        public ICollection<Inscricao> AlunosUC
        {
            get { return (ICollection<Inscricao>)dgView_Alunos.DataSource; }
            set { dgView_Alunos.DataSource = value; }
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
        public void SetUCListBindingSource(BindingSource ucList)
        {
            dgView_UC.DataSource = ucList;
        }

        //Singleton
        private static UCView instance;
        public static UCView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UCView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();

            }
            return instance;
        }
    }


}






