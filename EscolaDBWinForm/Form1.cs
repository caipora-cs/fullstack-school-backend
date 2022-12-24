using EscolaDBWinForm.Data;
using EscolaDBWinForm.Models;

namespace EscolaDBWinForm
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            using (var context = new EscolaDbContext())
            {
                alunos = context.Alunos.ToList();
            }
            dataGridView1.DataSource = alunos;
        }
    }
}