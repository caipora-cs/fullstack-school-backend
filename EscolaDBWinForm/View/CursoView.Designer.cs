namespace EscolaDBWinForm.View
{
    partial class CursoView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_CursoLista = new System.Windows.Forms.TabPage();
            this.tab_CursoDetalhe = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgView_CursosLista = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddCurso = new System.Windows.Forms.Button();
            this.btn_EditCurso = new System.Windows.Forms.Button();
            this.btn_DeleteCurso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgView_UC = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Referencia = new System.Windows.Forms.TextBox();
            this.tb_NomeCurso = new System.Windows.Forms.TextBox();
            this.tb_SiglaCurso = new System.Windows.Forms.TextBox();
            this.dTimeP_DataInicioCurso = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_CursoLista.SuspendLayout();
            this.tab_CursoDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_CursosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_CursoLista);
            this.tabControl1.Controls.Add(this.tab_CursoDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_CursoLista
            // 
            this.tab_CursoLista.Controls.Add(this.dgView_UC);
            this.tab_CursoLista.Controls.Add(this.label3);
            this.tab_CursoLista.Controls.Add(this.btn_DeleteCurso);
            this.tab_CursoLista.Controls.Add(this.btn_EditCurso);
            this.tab_CursoLista.Controls.Add(this.btn_AddCurso);
            this.tab_CursoLista.Controls.Add(this.btn_Search);
            this.tab_CursoLista.Controls.Add(this.dgView_CursosLista);
            this.tab_CursoLista.Controls.Add(this.tb_Search);
            this.tab_CursoLista.Controls.Add(this.label2);
            this.tab_CursoLista.Location = new System.Drawing.Point(4, 24);
            this.tab_CursoLista.Name = "tab_CursoLista";
            this.tab_CursoLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CursoLista.Size = new System.Drawing.Size(810, 365);
            this.tab_CursoLista.TabIndex = 0;
            this.tab_CursoLista.Text = "Cursos Lista";
            this.tab_CursoLista.UseVisualStyleBackColor = true;
            // 
            // tab_CursoDetalhe
            // 
            this.tab_CursoDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_CursoDetalhe.Controls.Add(this.btn_Save);
            this.tab_CursoDetalhe.Controls.Add(this.dTimeP_DataInicioCurso);
            this.tab_CursoDetalhe.Controls.Add(this.tb_SiglaCurso);
            this.tab_CursoDetalhe.Controls.Add(this.tb_NomeCurso);
            this.tab_CursoDetalhe.Controls.Add(this.tb_Referencia);
            this.tab_CursoDetalhe.Controls.Add(this.label7);
            this.tab_CursoDetalhe.Controls.Add(this.label6);
            this.tab_CursoDetalhe.Controls.Add(this.label5);
            this.tab_CursoDetalhe.Controls.Add(this.label4);
            this.tab_CursoDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_CursoDetalhe.Name = "tab_CursoDetalhe";
            this.tab_CursoDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CursoDetalhe.Size = new System.Drawing.Size(810, 365);
            this.tab_CursoDetalhe.TabIndex = 1;
            this.tab_CursoDetalhe.Text = "Curso Detalhe";
            this.tab_CursoDetalhe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Curso:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(103, 9);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(427, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // dgView_CursosLista
            // 
            this.dgView_CursosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_CursosLista.Location = new System.Drawing.Point(8, 38);
            this.dgView_CursosLista.Name = "dgView_CursosLista";
            this.dgView_CursosLista.RowTemplate.Height = 25;
            this.dgView_CursosLista.Size = new System.Drawing.Size(336, 321);
            this.dgView_CursosLista.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(546, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(119, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_AddCurso
            // 
            this.btn_AddCurso.Location = new System.Drawing.Point(671, 38);
            this.btn_AddCurso.Name = "btn_AddCurso";
            this.btn_AddCurso.Size = new System.Drawing.Size(136, 40);
            this.btn_AddCurso.TabIndex = 4;
            this.btn_AddCurso.Text = "Adicionar";
            this.btn_AddCurso.UseVisualStyleBackColor = true;
            // 
            // btn_EditCurso
            // 
            this.btn_EditCurso.Location = new System.Drawing.Point(671, 84);
            this.btn_EditCurso.Name = "btn_EditCurso";
            this.btn_EditCurso.Size = new System.Drawing.Size(136, 42);
            this.btn_EditCurso.TabIndex = 5;
            this.btn_EditCurso.Text = "Editar";
            this.btn_EditCurso.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteCurso
            // 
            this.btn_DeleteCurso.Location = new System.Drawing.Point(671, 132);
            this.btn_DeleteCurso.Name = "btn_DeleteCurso";
            this.btn_DeleteCurso.Size = new System.Drawing.Size(136, 44);
            this.btn_DeleteCurso.TabIndex = 6;
            this.btn_DeleteCurso.Text = "Deletar";
            this.btn_DeleteCurso.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "UCs do Curso:";
            // 
            // dgView_UC
            // 
            this.dgView_UC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_UC.Location = new System.Drawing.Point(350, 56);
            this.dgView_UC.Name = "dgView_UC";
            this.dgView_UC.RowTemplate.Height = 25;
            this.dgView_UC.Size = new System.Drawing.Size(315, 303);
            this.dgView_UC.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Referencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome do Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sigla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Data de Inicio";
            // 
            // tb_Referencia
            // 
            this.tb_Referencia.Location = new System.Drawing.Point(50, 47);
            this.tb_Referencia.Name = "tb_Referencia";
            this.tb_Referencia.Size = new System.Drawing.Size(100, 23);
            this.tb_Referencia.TabIndex = 4;
            // 
            // tb_NomeCurso
            // 
            this.tb_NomeCurso.Location = new System.Drawing.Point(50, 134);
            this.tb_NomeCurso.Name = "tb_NomeCurso";
            this.tb_NomeCurso.Size = new System.Drawing.Size(200, 23);
            this.tb_NomeCurso.TabIndex = 5;
            // 
            // tb_SiglaCurso
            // 
            this.tb_SiglaCurso.Location = new System.Drawing.Point(278, 134);
            this.tb_SiglaCurso.Name = "tb_SiglaCurso";
            this.tb_SiglaCurso.Size = new System.Drawing.Size(75, 23);
            this.tb_SiglaCurso.TabIndex = 6;
            // 
            // dTimeP_DataInicioCurso
            // 
            this.dTimeP_DataInicioCurso.Location = new System.Drawing.Point(50, 223);
            this.dTimeP_DataInicioCurso.Name = "dTimeP_DataInicioCurso";
            this.dTimeP_DataInicioCurso.Size = new System.Drawing.Size(200, 23);
            this.dTimeP_DataInicioCurso.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(576, 294);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 46);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(665, 294);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(83, 46);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(763, 21);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(33, 27);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // CursoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "CursoView";
            this.Text = "CursoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_CursoLista.ResumeLayout(false);
            this.tab_CursoLista.PerformLayout();
            this.tab_CursoDetalhe.ResumeLayout(false);
            this.tab_CursoDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_CursosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_CursoLista;
        private TabPage tab_CursoDetalhe;
        private DataGridView dgView_UC;
        private Label label3;
        private Button btn_DeleteCurso;
        private Button btn_EditCurso;
        private Button btn_AddCurso;
        private Button btn_Search;
        private DataGridView dgView_CursosLista;
        private TextBox tb_Search;
        private Label label2;
        private Button btn_Cancel;
        private Button btn_Save;
        private DateTimePicker dTimeP_DataInicioCurso;
        private TextBox tb_SiglaCurso;
        private TextBox tb_NomeCurso;
        private TextBox tb_Referencia;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_Close;
    }
}