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
    public partial class AnoLetivoView : Form, IAnoLetivoView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public AnoLetivoView()
        {
            InitializeComponent();
            MatchAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tab_AnoDetalhe);
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

            btn_AddAno.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_AnoLista);
                tabControl1.TabPages.Add(tab_AnoDetalhe);
                tab_AnoDetalhe.Text = "Adicionar Ano Letivo";
            };

            btn_EditAno.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_AnoLista);
                tabControl1.TabPages.Add(tab_AnoDetalhe);
                tab_AnoDetalhe.Text = "Editar Ano Letivo";
            };

            btn_Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tab_AnoDetalhe);
                tabControl1.TabPages.Add(tab_AnoLista);
            };

            btn_Save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tab_AnoDetalhe);
                    tabControl1.TabPages.Add(tab_AnoLista);
                }
                MessageBox.Show(Message);

            };

            btn_DeleteAno.Click += delegate
            {
                var answer = MessageBox.Show("Tem a certeza que deseja deletar o Ano Letivo selecionado?", "Atencao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    //Se sim, entao chama o evento de delete
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    //Mostra resultado da operacao
                    MessageBox.Show(Message);
                }

            };


            dgView_Ano.SelectionChanged += delegate { SelectEvent?.Invoke(this, EventArgs.Empty); };
        }

        //Propriedades
        public short IdAno
        {
            get { return Convert.ToInt16(tb_IdAno.Text); }
            set { tb_IdAno.Text = value.ToString(); }
        }

        public short AnoLetivoInicial
        {
            get { return Convert.ToInt16(tb_AnoInicial.Text); }
            set { tb_AnoInicial.Text = value.ToString(); }
        }

        public short AnoLetivoFinal
        {
            get { return Convert.ToInt16(tb_AnoFinal.Text); }
            set { tb_AnoFinal.Text = value.ToString(); }
        }

        public ICollection<Inscricao> InscricaosAnoLetivo
        {
            get { return (ICollection<Inscricao>)dgView_Inscricoes.DataSource; }
        }

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
        public void SetAnoLetivoListBindingSource(BindingSource ano)
        {
            dgView_Ano.DataSource = ano;
        }

        public void SetInscricaoListBindingSource(BindingSource inscricaoList)
        {
            dgView_Inscricoes.DataSource = inscricaoList;
        }

        //Singleton
        private static AnoLetivoView instance;
        public static AnoLetivoView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AnoLetivoView();
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