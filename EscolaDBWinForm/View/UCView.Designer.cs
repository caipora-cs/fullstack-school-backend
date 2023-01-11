namespace EscolaDBWinForm.View
{
    partial class UCView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_UCLista = new System.Windows.Forms.TabPage();
            this.tab_UCDetalhe = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgView_UC = new System.Windows.Forms.DataGridView();
            this.dvView_Alunos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddUC = new System.Windows.Forms.Button();
            this.btn_EditUC = new System.Windows.Forms.Button();
            this.btn_DeleteUC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_ReferenciaCurso = new System.Windows.Forms.TextBox();
            this.tb_NumeroDocente = new System.Windows.Forms.TextBox();
            this.tb_NomeUC = new System.Windows.Forms.TextBox();
            this.tb_SiglaUC = new System.Windows.Forms.TextBox();
            this.tb_Creditos = new System.Windows.Forms.TextBox();
            this.tb_AnoUC = new System.Windows.Forms.TextBox();
            this.tb_SemestreUC = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_UCLista.SuspendLayout();
            this.tab_UCDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvView_Alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidades Curriculares";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(742, 27);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(34, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_UCLista);
            this.tabControl1.Controls.Add(this.tab_UCDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 380);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_UCLista
            // 
            this.tab_UCLista.Controls.Add(this.btn_DeleteUC);
            this.tab_UCLista.Controls.Add(this.btn_EditUC);
            this.tab_UCLista.Controls.Add(this.btn_AddUC);
            this.tab_UCLista.Controls.Add(this.btn_Search);
            this.tab_UCLista.Controls.Add(this.label3);
            this.tab_UCLista.Controls.Add(this.dvView_Alunos);
            this.tab_UCLista.Controls.Add(this.dgView_UC);
            this.tab_UCLista.Controls.Add(this.tb_Search);
            this.tab_UCLista.Controls.Add(this.label2);
            this.tab_UCLista.Location = new System.Drawing.Point(4, 24);
            this.tab_UCLista.Name = "tab_UCLista";
            this.tab_UCLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UCLista.Size = new System.Drawing.Size(815, 352);
            this.tab_UCLista.TabIndex = 0;
            this.tab_UCLista.Text = "UC Lista";
            this.tab_UCLista.UseVisualStyleBackColor = true;
            // 
            // tab_UCDetalhe
            // 
            this.tab_UCDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_UCDetalhe.Controls.Add(this.btn_Save);
            this.tab_UCDetalhe.Controls.Add(this.tb_SemestreUC);
            this.tab_UCDetalhe.Controls.Add(this.tb_AnoUC);
            this.tab_UCDetalhe.Controls.Add(this.tb_Creditos);
            this.tab_UCDetalhe.Controls.Add(this.tb_SiglaUC);
            this.tab_UCDetalhe.Controls.Add(this.tb_NomeUC);
            this.tab_UCDetalhe.Controls.Add(this.tb_NumeroDocente);
            this.tab_UCDetalhe.Controls.Add(this.tb_ReferenciaCurso);
            this.tab_UCDetalhe.Controls.Add(this.tb_Id);
            this.tab_UCDetalhe.Controls.Add(this.label11);
            this.tab_UCDetalhe.Controls.Add(this.label10);
            this.tab_UCDetalhe.Controls.Add(this.label9);
            this.tab_UCDetalhe.Controls.Add(this.label8);
            this.tab_UCDetalhe.Controls.Add(this.label7);
            this.tab_UCDetalhe.Controls.Add(this.label6);
            this.tab_UCDetalhe.Controls.Add(this.label5);
            this.tab_UCDetalhe.Controls.Add(this.label4);
            this.tab_UCDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_UCDetalhe.Name = "tab_UCDetalhe";
            this.tab_UCDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UCDetalhe.Size = new System.Drawing.Size(815, 352);
            this.tab_UCDetalhe.TabIndex = 1;
            this.tab_UCDetalhe.Text = "UC Detalhe";
            this.tab_UCDetalhe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar UC:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(86, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(528, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // dgView_UC
            // 
            this.dgView_UC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_UC.Location = new System.Drawing.Point(3, 39);
            this.dgView_UC.Name = "dgView_UC";
            this.dgView_UC.RowTemplate.Height = 25;
            this.dgView_UC.Size = new System.Drawing.Size(398, 313);
            this.dgView_UC.TabIndex = 2;
            // 
            // dvView_Alunos
            // 
            this.dvView_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvView_Alunos.Location = new System.Drawing.Point(407, 57);
            this.dvView_Alunos.Name = "dvView_Alunos";
            this.dvView_Alunos.RowTemplate.Height = 25;
            this.dvView_Alunos.Size = new System.Drawing.Size(293, 295);
            this.dvView_Alunos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alunos da UC:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(625, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_AddUC
            // 
            this.btn_AddUC.Location = new System.Drawing.Point(706, 39);
            this.btn_AddUC.Name = "btn_AddUC";
            this.btn_AddUC.Size = new System.Drawing.Size(106, 34);
            this.btn_AddUC.TabIndex = 6;
            this.btn_AddUC.Text = "Adicionar";
            this.btn_AddUC.UseVisualStyleBackColor = true;
            // 
            // btn_EditUC
            // 
            this.btn_EditUC.Location = new System.Drawing.Point(706, 79);
            this.btn_EditUC.Name = "btn_EditUC";
            this.btn_EditUC.Size = new System.Drawing.Size(109, 35);
            this.btn_EditUC.TabIndex = 7;
            this.btn_EditUC.Text = "Editar";
            this.btn_EditUC.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteUC
            // 
            this.btn_DeleteUC.Location = new System.Drawing.Point(706, 120);
            this.btn_DeleteUC.Name = "btn_DeleteUC";
            this.btn_DeleteUC.Size = new System.Drawing.Size(109, 38);
            this.btn_DeleteUC.TabIndex = 8;
            this.btn_DeleteUC.Text = "Deletar";
            this.btn_DeleteUC.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Referencia de Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero Docente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sigla:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Creditos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ano:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Semestre:";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(19, 37);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(101, 23);
            this.tb_Id.TabIndex = 8;
            // 
            // tb_ReferenciaCurso
            // 
            this.tb_ReferenciaCurso.Location = new System.Drawing.Point(20, 86);
            this.tb_ReferenciaCurso.Name = "tb_ReferenciaCurso";
            this.tb_ReferenciaCurso.Size = new System.Drawing.Size(100, 23);
            this.tb_ReferenciaCurso.TabIndex = 9;
            // 
            // tb_NumeroDocente
            // 
            this.tb_NumeroDocente.Location = new System.Drawing.Point(20, 130);
            this.tb_NumeroDocente.Name = "tb_NumeroDocente";
            this.tb_NumeroDocente.Size = new System.Drawing.Size(100, 23);
            this.tb_NumeroDocente.TabIndex = 10;
            // 
            // tb_NomeUC
            // 
            this.tb_NomeUC.Location = new System.Drawing.Point(19, 188);
            this.tb_NomeUC.Name = "tb_NomeUC";
            this.tb_NomeUC.Size = new System.Drawing.Size(246, 23);
            this.tb_NomeUC.TabIndex = 11;
            // 
            // tb_SiglaUC
            // 
            this.tb_SiglaUC.Location = new System.Drawing.Point(285, 188);
            this.tb_SiglaUC.Name = "tb_SiglaUC";
            this.tb_SiglaUC.Size = new System.Drawing.Size(59, 23);
            this.tb_SiglaUC.TabIndex = 12;
            // 
            // tb_Creditos
            // 
            this.tb_Creditos.Location = new System.Drawing.Point(364, 188);
            this.tb_Creditos.Name = "tb_Creditos";
            this.tb_Creditos.Size = new System.Drawing.Size(65, 23);
            this.tb_Creditos.TabIndex = 13;
            // 
            // tb_AnoUC
            // 
            this.tb_AnoUC.Location = new System.Drawing.Point(19, 253);
            this.tb_AnoUC.Name = "tb_AnoUC";
            this.tb_AnoUC.Size = new System.Drawing.Size(43, 23);
            this.tb_AnoUC.TabIndex = 14;
            // 
            // tb_SemestreUC
            // 
            this.tb_SemestreUC.Location = new System.Drawing.Point(105, 253);
            this.tb_SemestreUC.Name = "tb_SemestreUC";
            this.tb_SemestreUC.Size = new System.Drawing.Size(45, 23);
            this.tb_SemestreUC.TabIndex = 15;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(619, 286);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 45);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(706, 286);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 45);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // UCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "UCView";
            this.Text = "UCView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_UCLista.ResumeLayout(false);
            this.tab_UCLista.PerformLayout();
            this.tab_UCDetalhe.ResumeLayout(false);
            this.tab_UCDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvView_Alunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_UCLista;
        private TabPage tab_UCDetalhe;
        private Label label2;
        private TextBox tb_Search;
        private DataGridView dgView_UC;
        private Button btn_DeleteUC;
        private Button btn_EditUC;
        private Button btn_AddUC;
        private Button btn_Search;
        private Label label3;
        private DataGridView dvView_Alunos;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tb_Creditos;
        private TextBox tb_SiglaUC;
        private TextBox tb_NomeUC;
        private TextBox tb_NumeroDocente;
        private TextBox tb_ReferenciaCurso;
        private TextBox tb_Id;
        private TextBox tb_SemestreUC;
        private TextBox tb_AnoUC;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}