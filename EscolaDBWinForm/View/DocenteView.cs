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

namespace EscolaDBWinForm.View
{
    public partial class DocenteView : Form, IDocenteView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public DocenteView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_DocenteDetalhe);
            btn_Close.Click += delegate { this.Close(); };
        }

        private void MatchAndRaiseViewEvents()
        {
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tb_Search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btn_AddDocente.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_DocenteLista);
                tabControl1.TabPages.Add(tab_DocenteDetalhe);
                tab_DocenteDetalhe.Text = "Adicionar Docente";
            };
            btn_EditDocente.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_DocenteLista);
                tabControl1.TabPages.Add(tab_DocenteDetalhe);
                tab_DocenteDetalhe.Text = "Editar Docente";
                tb_NumeroDocente.ReadOnly = true;
            };
            btn_DeleteDocente.Click += delegate
            {
                var answer = MessageBox.Show("Tem a certeza que deseja deletar o Docente selecionado?","Atencao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
 
            };
            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tab_DocenteDetalhe);
                    tabControl1.TabPages.Add(tab_DocenteLista);
                }
                MessageBox.Show(Message);
            };
            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_DocenteDetalhe);
                tabControl1.TabPages.Add(tab_DocenteLista);
            };

            dgView_Docente.SelectionChanged += delegate
            {
                SelectEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public int NumeroDocente { get => int.Parse(tb_NumeroDocente.Text); set => tb_NumeroDocente.Text = value.ToString(); }
        public string NomeDocente { get => tb_NomeDocente.Text; set => tb_NomeDocente.Text = value; }
        public string ApelidoDocente { get => tb_Apelido.Text; set => tb_Apelido.Text = value; }
        public DateTime? DataNascimentoDocente { get => dTimeP_DataNascimento.Value; set => dTimeP_DataNascimento.Value = value ?? DateTime.Now; }
        public string EmailDocente { get => tb_EmailDocente.Text; set => tb_EmailDocente.Text = value; }
        public string TelefoneDocente { get => tb_TelefoneDocente.Text; set => tb_TelefoneDocente.Text = value; }
        public string ExtensaoDocente { get => tb_ExtensaoDocente.Text; set => tb_ExtensaoDocente.Text = value; }
        public decimal SalarioDocente { get => decimal.Parse(tb_SalarioDocente.Text); set => tb_SalarioDocente.Text = value.ToString(); }
        public ICollection<UnidadeCurricular> UnidadeCurricularDocente
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
        public event EventHandler SelectEvent;

        //Metodos 
        public void SetDocenteListBindingSource(BindingSource cursoList)
        {
            dgView_Docente.DataSource = cursoList;
        }

        public void SetUnidadeCurricularListBindingSource(BindingSource ucList)
        {
            dgView_UC.DataSource = ucList;
        }

        //Single Page enforcer: Abre um form apenas.
        private static DocenteView instance;
        //Metodo aceita um parent container para ser instanciado em MDI single page 
        public static DocenteView GetInstance(Form parentContainer)
        {
            //Checka se a view esta fechada e cria uma nova view
            if (instance == null || instance.IsDisposed)
            {
                instance = new DocenteView();
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
