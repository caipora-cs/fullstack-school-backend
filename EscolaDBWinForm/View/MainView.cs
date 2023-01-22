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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            //MS Doc on 'delegate':
            //Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates.
            btn_AlunosView.Click += delegate { ShowAlunosView?.Invoke(this, EventArgs.Empty); };
            btn_CursosView.Click += delegate { ShowCursosView?.Invoke(this, EventArgs.Empty); };
            btn_UCsView.Click += delegate { ShowUnidadeCurricularView?.Invoke(this, EventArgs.Empty); };
            btn_AnosView.Click += delegate { ShowAnoLetivoView?.Invoke(this, EventArgs.Empty); };
            btn_EpocasAView.Click += delegate { ShowEpocaAvaliacaoView?.Invoke(this, EventArgs.Empty); };
            btn_EEpocasView.Click += delegate { ShowEstadoEpocaView?.Invoke(this, EventArgs.Empty); };
            btn_InscricaosView.Click += delegate { ShowInscricoesView?.Invoke(this, EventArgs.Empty); };
            btn_DocentesView.Click += delegate { ShowDocentesView?.Invoke(this, EventArgs.Empty); };
            btn_Acerca.Click += delegate { AcercaView?.Invoke(this, EventArgs.Empty); };
            btn_Sair.Click += delegate { SairView?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowAlunosView;
        public event EventHandler ShowCursosView;
        public event EventHandler ShowUnidadeCurricularView;
        public event EventHandler ShowDocentesView;
        public event EventHandler ShowInscricoesView;
        public event EventHandler ShowAnoLetivoView;
        public event EventHandler ShowEpocaAvaliacaoView;
        public event EventHandler ShowEstadoEpocaView;
        public event EventHandler AcercaView;
        public event EventHandler SairView;
    }
}
