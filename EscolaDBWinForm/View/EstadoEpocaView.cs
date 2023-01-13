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
    public partial class EstadoEpocaView : Form, IEstadoEpocaView
    {
        //Propriedades
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public EstadoEpocaView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_EEpocaDetalhe);
            btn_Close.Click += delegate { this.Close(); };
        }

        private void MatchAndRaiseViewEvents()
        {
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tb_Search.KeyDown += (s,e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            btn_AddEEpoca.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EEpocaLista);
                tabControl1.TabPages.Add(tab_EEpocaDetalhe);
                tab_EEpocaDetalhe.Text = "Adicionar Estado de Epoca";
            };

            btn_EditEEpoca.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EEpocaLista);
                tabControl1.TabPages.Add(tab_EEpocaDetalhe);
                tab_EEpocaDetalhe.Text = "Editar Estado de Epoca";
            };


            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EEpocaDetalhe);
                tabControl1.TabPages.Add(tab_EEpocaLista);
            };

            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tab_EEpocaDetalhe);
                    tabControl1.TabPages.Add(tab_EEpocaLista);
                }
                MessageBox.Show(Message);
            };

            btn_DeleteEEpoca.Click += delegate
            {
                var answer = MessageBox.Show("Tem a certeza que deseja deletar a Epoca selecionado?","Atencao",
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
        public short IdEEpoca
        {
            get { return Convert.ToInt16(tb_IdEEpoca.Text); }
            set { tb_IdEEpoca.Text = value.ToString(); }
        }

        public string DescricaoEEpoca
        {
            get { return tb_DescricaoEEpoca.Text; }
            set { tb_DescricaoEEpoca.Text = value; }
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
        public void SetEEpocaListBindingSource(BindingSource e_epoca)
        {
            dgView_EEpoca.DataSource = e_epoca;
        }

        //Singleton
        private static EstadoEpocaView instance;
        public static EstadoEpocaView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EstadoEpocaView();
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
