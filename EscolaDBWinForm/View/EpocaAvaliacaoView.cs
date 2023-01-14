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
    public partial class EpocaAvaliacaoView : Form, IEpocaAvaliacaoView
    {
        //Propriedades
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public EpocaAvaliacaoView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_EpocaADetalhe);
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

            btn_AddEpocaA.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EpocaALista);
                tabControl1.TabPages.Add(tab_EpocaADetalhe);
                tab_EpocaADetalhe.Text = "Adicionar Epoca de Avaliacao";
            };

            btn_EditEpocaA.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EpocaALista);
                tabControl1.TabPages.Add(tab_EpocaADetalhe);
                tab_EpocaADetalhe.Text = "Editar Epoca de Avaliacao";
            };

            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_EpocaADetalhe);
                tabControl1.TabPages.Add(tab_EpocaALista);
            };

            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tab_EpocaADetalhe);
                    tabControl1.TabPages.Add(tab_EpocaALista);
                }
                MessageBox.Show(message);
            };

            btn_DeleteEpocaA.Click += delegate
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
        public string IdEpocaA
        {
            get { return tb_IdEpocaA.Text; }
            set { tb_IdEpocaA.Text = value; }
        }

        public string DescricaoEpocaA
        {
            get { return tb_DescricaoEpocaA.Text; }
            set { tb_DescricaoEpocaA.Text = value; }
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
        public void SetEpocaAListBindingSource(BindingSource epoca_a)
        {
            dgView_EpocaA.DataSource = epoca_a;
        }

        //Singleton
        private static EpocaAvaliacaoView instance;
        public static EpocaAvaliacaoView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EpocaAvaliacaoView();
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
