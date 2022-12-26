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

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno
            {
                NomeProprio = txtBox_NomeProprio.Text,
                Apelido = txtBox_Apelido.Text,
                DataNascimento = dateTimePicker1.Value,
                Morada = txtBox_Morada.Text,
                Email = txtBox_Email.Text,
                Telefone = txtBox_Telefone.Text,
                ReferenciaCurso = (int)comboBox1.SelectedValue
            };

            using (var context = new EscolaDbContext())
            {
                context.Alunos.Add(aluno);
                context.SaveChanges();
            }
            alunos.Add(aluno);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alunos;
        }
    }
}