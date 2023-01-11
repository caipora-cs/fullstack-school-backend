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
        }

        public event EventHandler ShowAlunosView;
        public event EventHandler ShowCursosView;
        public event EventHandler ShowUnidadeCurricular;
        public event EventHandler ShowCurso;
        public event EventHandler ShowDocente;
        public event EventHandler ShowInscricao;
        public event EventHandler ShowAnoLetivo;
        public event EventHandler ShowEpocaAvaliacao;
        public event EventHandler ShowEstadoEpoca;
    }
}
