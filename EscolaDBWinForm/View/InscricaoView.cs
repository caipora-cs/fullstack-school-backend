using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaDBWinForm.View
{
    public partial class InscricaoView : Form, IInscricaoView
    {
        //Propriedades
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public InscricaoView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_InscricaoDetalhe);
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

            btn_AddInscricao.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_InscricaoLista);
                tabControl1.TabPages.Add(tab_InscricaoDetalhe);
                tab_InscricaoDetalhe.Text = "Adicionar Inscricao";
            };

            btn_EditInscricao.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_InscricaoLista);
                tabControl1.TabPages.Add(tab_InscricaoDetalhe);
                tab_InscricaoDetalhe.Text = "Editar Inscricao";
            };

            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tab_InscricaoDetalhe);
                    tabControl1.TabPages.Add(tab_InscricaoLista);
                }
                MessageBox.Show(Message);
            };

            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_InscricaoDetalhe);
                tabControl1.TabPages.Add(tab_InscricaoLista);
            };

            btn_DeleteInscricao.Click += delegate
            {
                var answer = MessageBox.Show("Tem a certeza que deseja deletar a Inscricao selecionada?","Atencao",
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

        public int NumeroAlunoInscricao
        {
            get { return Convert.ToInt32(tb_NumeroAlunoInscricao.Text); }
            set { tb_NumeroAlunoInscricao.Text = value.ToString(); }
        }

        public int IdUCInscricao
        {
            //get the selected item underlying Id from the Database (not the displayed text) and return it
            get { return Convert.ToInt32(cb_UCInscricao.SelectedValue); }
            set { cb_UCInscricao.Text = value.ToString(); }
        }

        public short IdAnoInscricao
        {
            get { return Convert.ToInt16(cb_AnoInscricao.SelectedValue); }
            set { cb_AnoInscricao.Text = value.ToString(); }
        }

        public string IdEpocaAInscricao
        {
            get { return cb_EpocaAInscricao.SelectedValue.ToString(); }
            set { cb_EpocaAInscricao.Text = value; }
        }

        public short? IdEEpocaInscricao
        {
            get { return Convert.ToInt16(cb_EEpocaInscricao.SelectedValue); }
            set { cb_EEpocaInscricao.Text = value.ToString(); }
        }

        public string? PresencaInscricao
        {
            get { return tb_PresencaInscricao.Text; }
            set { tb_PresencaInscricao.Text = value; }
        }

        public short? NotaInscricao
        {
            // Check if the value is null, if it is, return null, otherwise return the value converted to short
            get { return string.IsNullOrEmpty(tb_NotaInscricao.Text) ? (short?)null : Convert.ToInt16(tb_NotaInscricao.Text); }
            set { tb_NotaInscricao.Text = value.ToString(); }
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
        public void SetInscricaoListBindingSource(BindingSource inscricao)
        {
            dgView_Inscricao.DataSource = inscricao;
        }

        public void SetUCListBindingSource(BindingSource uc)
        {
            cb_UCInscricao.DataSource = uc;
            cb_UCInscricao.DisplayMember = "Nome";
            cb_UCInscricao.ValueMember = "Id";
        }

        public void SetAnoListBindingSource(BindingSource ano)
        {
            cb_AnoInscricao.DataSource = ano;
            cb_AnoInscricao.DisplayMember = "AnoInicial";
            cb_AnoInscricao.ValueMember = "Id";
        }

        public void SetEpocaAListBindingSource(BindingSource epocaa)
        {
            cb_EpocaAInscricao.DataSource = epocaa;
            cb_EpocaAInscricao.DisplayMember = "Descricao";
            cb_EpocaAInscricao.ValueMember = "Id";
        }

        public void SetEEpocaListBindingSource(BindingSource eepoca)
        {
            cb_EEpocaInscricao.DataSource = eepoca;
            cb_EEpocaInscricao.DisplayMember = "Descricao";
            cb_EEpocaInscricao.ValueMember = "Id";
        }

        //Metodos Auxiliares para Read Only
        //So deixa o utilizador editar os campos Presenca e Nota
        /*public void SetReadOnlyPresencaNota()
        {
            tb_NumeroAlunoInscricao.ReadOnly = true;
            cb_UCInscricao.Enabled = false;
            cb_AnoInscricao.Enabled = false;
            cb_EpocaAInscricao.Enabled = false;
            cb_EEpocaInscricao.Enabled = false;
        }
        //Nao deixa o utilizador editar nada
        public void SetReadOnlyAll()
        {
            tb_NumeroAlunoInscricao.ReadOnly = true;
            cb_UCInscricao.Enabled = false;
            cb_AnoInscricao.Enabled = false;
            cb_EpocaAInscricao.Enabled = false;
            cb_EEpocaInscricao.Enabled = false;
            tb_PresencaInscricao.ReadOnly = true;
            tb_NotaInscricao.ReadOnly = true;
        }*/

        //Singleton
        private static InscricaoView instance;
        public static InscricaoView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new InscricaoView();
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
