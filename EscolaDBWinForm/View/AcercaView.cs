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
    public partial class AcercaView : Form
    {
        public AcercaView()
        {
            InitializeComponent();
            btn_Close.Click += delegate { this.Close(); };
        }
        private static AcercaView instance;
        public static AcercaView GetInstance(Form parentContainer)
        {
            //Checka se a view esta fechada e cria uma nova view
            if (instance == null || instance.IsDisposed)
            {
                instance = new AcercaView();
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
