namespace EscolaDBWinForm.View
{
    partial class AlunoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_AlunosLista = new System.Windows.Forms.TabPage();
            this.btn_DeleteAluno = new System.Windows.Forms.Button();
            this.btn_EditAluno = new System.Windows.Forms.Button();
            this.btn_AddAluno = new System.Windows.Forms.Button();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tB_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_AlunoDetalhe = new System.Windows.Forms.TabPage();
            this.tb_NumeroAluno = new System.Windows.Forms.TextBox();
            this.dTimeP_AnoCurso = new System.Windows.Forms.DateTimePicker();
            this.dTimeP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.AnoCurso = new System.Windows.Forms.Label();
            this.tb_Curso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Morada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Apelido = new System.Windows.Forms.TextBox();
            this.tb_NomeAluno = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_AlunosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            this.tab_AlunoDetalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUNOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(750, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(38, 36);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_AlunosLista);
            this.tabControl1.Controls.Add(this.tab_AlunoDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_AlunosLista
            // 
            this.tab_AlunosLista.Controls.Add(this.btn_DeleteAluno);
            this.tab_AlunosLista.Controls.Add(this.btn_EditAluno);
            this.tab_AlunosLista.Controls.Add(this.btn_AddAluno);
            this.tab_AlunosLista.Controls.Add(this.dgv_Alunos);
            this.tab_AlunosLista.Controls.Add(this.btn_Search);
            this.tab_AlunosLista.Controls.Add(this.tB_Search);
            this.tab_AlunosLista.Controls.Add(this.label2);
            this.tab_AlunosLista.Location = new System.Drawing.Point(4, 24);
            this.tab_AlunosLista.Name = "tab_AlunosLista";
            this.tab_AlunosLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AlunosLista.Size = new System.Drawing.Size(792, 356);
            this.tab_AlunosLista.TabIndex = 0;
            this.tab_AlunosLista.Text = "Alunos Lista";
            this.tab_AlunosLista.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteAluno
            // 
            this.btn_DeleteAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteAluno.Location = new System.Drawing.Point(667, 126);
            this.btn_DeleteAluno.Name = "btn_DeleteAluno";
            this.btn_DeleteAluno.Size = new System.Drawing.Size(119, 42);
            this.btn_DeleteAluno.TabIndex = 6;
            this.btn_DeleteAluno.Text = "Deletar";
            this.btn_DeleteAluno.UseVisualStyleBackColor = true;
            // 
            // btn_EditAluno
            // 
            this.btn_EditAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditAluno.Location = new System.Drawing.Point(667, 82);
            this.btn_EditAluno.Name = "btn_EditAluno";
            this.btn_EditAluno.Size = new System.Drawing.Size(119, 38);
            this.btn_EditAluno.TabIndex = 5;
            this.btn_EditAluno.Text = "Editar";
            this.btn_EditAluno.UseVisualStyleBackColor = true;
            // 
            // btn_AddAluno
            // 
            this.btn_AddAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAluno.Location = new System.Drawing.Point(667, 38);
            this.btn_AddAluno.Name = "btn_AddAluno";
            this.btn_AddAluno.Size = new System.Drawing.Size(119, 38);
            this.btn_AddAluno.TabIndex = 4;
            this.btn_AddAluno.Text = "Adicionar";
            this.btn_AddAluno.UseVisualStyleBackColor = true;
            // 
            // dgv_Alunos
            // 
            this.dgv_Alunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.Location = new System.Drawing.Point(8, 38);
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.RowTemplate.Height = 25;
            this.dgv_Alunos.Size = new System.Drawing.Size(653, 312);
            this.dgv_Alunos.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(586, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tB_Search
            // 
            this.tB_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Search.Location = new System.Drawing.Point(104, 9);
            this.tB_Search.Name = "tB_Search";
            this.tB_Search.Size = new System.Drawing.Size(462, 23);
            this.tB_Search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Aluno:";
            // 
            // tab_AlunoDetalhe
            // 
            this.tab_AlunoDetalhe.Controls.Add(this.tb_NumeroAluno);
            this.tab_AlunoDetalhe.Controls.Add(this.dTimeP_AnoCurso);
            this.tab_AlunoDetalhe.Controls.Add(this.dTimeP_DataNascimento);
            this.tab_AlunoDetalhe.Controls.Add(this.AnoCurso);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_Curso);
            this.tab_AlunoDetalhe.Controls.Add(this.label11);
            this.tab_AlunoDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_AlunoDetalhe.Controls.Add(this.btn_Save);
            this.tab_AlunoDetalhe.Controls.Add(this.label10);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_Telefone);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_Email);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_Morada);
            this.tab_AlunoDetalhe.Controls.Add(this.label9);
            this.tab_AlunoDetalhe.Controls.Add(this.label8);
            this.tab_AlunoDetalhe.Controls.Add(this.label7);
            this.tab_AlunoDetalhe.Controls.Add(this.label6);
            this.tab_AlunoDetalhe.Controls.Add(this.label5);
            this.tab_AlunoDetalhe.Controls.Add(this.label4);
            this.tab_AlunoDetalhe.Controls.Add(this.label3);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_Apelido);
            this.tab_AlunoDetalhe.Controls.Add(this.tb_NomeAluno);
            this.tab_AlunoDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_AlunoDetalhe.Name = "tab_AlunoDetalhe";
            this.tab_AlunoDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AlunoDetalhe.Size = new System.Drawing.Size(792, 356);
            this.tab_AlunoDetalhe.TabIndex = 1;
            this.tab_AlunoDetalhe.Text = "Aluno Detalhe";
            this.tab_AlunoDetalhe.UseVisualStyleBackColor = true;
            // 
            // tb_NumeroAluno
            // 
            this.tb_NumeroAluno.Location = new System.Drawing.Point(47, 30);
            this.tb_NumeroAluno.Name = "tb_NumeroAluno";
            this.tb_NumeroAluno.ReadOnly = true;
            this.tb_NumeroAluno.Size = new System.Drawing.Size(102, 23);
            this.tb_NumeroAluno.TabIndex = 24;
            // 
            // dTimeP_AnoCurso
            // 
            this.dTimeP_AnoCurso.Location = new System.Drawing.Point(554, 252);
            this.dTimeP_AnoCurso.Name = "dTimeP_AnoCurso";
            this.dTimeP_AnoCurso.Size = new System.Drawing.Size(187, 23);
            this.dTimeP_AnoCurso.TabIndex = 22;
            // 
            // dTimeP_DataNascimento
            // 
            this.dTimeP_DataNascimento.Location = new System.Drawing.Point(51, 167);
            this.dTimeP_DataNascimento.Name = "dTimeP_DataNascimento";
            this.dTimeP_DataNascimento.Size = new System.Drawing.Size(200, 23);
            this.dTimeP_DataNascimento.TabIndex = 21;
            // 
            // AnoCurso
            // 
            this.AnoCurso.AutoSize = true;
            this.AnoCurso.Location = new System.Drawing.Point(560, 230);
            this.AnoCurso.Name = "AnoCurso";
            this.AnoCurso.Size = new System.Drawing.Size(29, 15);
            this.AnoCurso.TabIndex = 19;
            this.AnoCurso.Text = "Ano";
            // 
            // tb_Curso
            // 
            this.tb_Curso.Location = new System.Drawing.Point(554, 198);
            this.tb_Curso.Name = "tb_Curso";
            this.tb_Curso.Size = new System.Drawing.Size(187, 23);
            this.tb_Curso.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Curso";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(648, 281);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 41);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(554, 281);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 41);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Numero";
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(270, 291);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(121, 23);
            this.tb_Telefone.TabIndex = 13;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(51, 291);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(208, 23);
            this.tb_Email.TabIndex = 12;
            // 
            // tb_Morada
            // 
            this.tb_Morada.Location = new System.Drawing.Point(47, 224);
            this.tb_Morada.Name = "tb_Morada";
            this.tb_Morada.Size = new System.Drawing.Size(344, 23);
            this.tb_Morada.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Foto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Morada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // tb_Apelido
            // 
            this.tb_Apelido.Location = new System.Drawing.Point(227, 103);
            this.tb_Apelido.Name = "tb_Apelido";
            this.tb_Apelido.Size = new System.Drawing.Size(164, 23);
            this.tb_Apelido.TabIndex = 2;
            // 
            // tb_NomeAluno
            // 
            this.tb_NomeAluno.Location = new System.Drawing.Point(47, 103);
            this.tb_NomeAluno.Name = "tb_NomeAluno";
            this.tb_NomeAluno.Size = new System.Drawing.Size(159, 23);
            this.tb_NomeAluno.TabIndex = 1;
            // 
            // AlunoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AlunoView";
            this.Text = "AlunoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_AlunosLista.ResumeLayout(false);
            this.tab_AlunosLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            this.tab_AlunoDetalhe.ResumeLayout(false);
            this.tab_AlunoDetalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tab_AlunosLista;
        private Button btn_DeleteAluno;
        private Button btn_EditAluno;
        private Button btn_AddAluno;
        private DataGridView dgv_Alunos;
        private Button btn_Search;
        private TextBox tB_Search;
        private Label label2;
        private TabPage tab_AlunoDetalhe;
        private TextBox tb_NomeAluno;
        private Label label10;
        private TextBox tb_Telefone;
        private TextBox tb_Email;
        private TextBox tb_Morada;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tb_Apelido;
        private Button btn_Cancel;
        private Button btn_Save;
        private TextBox tb_Curso;
        private Label label11;
        private Label AnoCurso;
        private DateTimePicker dTimeP_AnoCurso;
        private DateTimePicker dTimeP_DataNascimento;
        private Button btn_Close;
        private TextBox tb_NumeroAluno;
    }
}