namespace EscolaDBWinForm.View
{
    partial class DocenteView
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_DocenteLista = new System.Windows.Forms.TabPage();
            this.btn_DeleteDocente = new System.Windows.Forms.Button();
            this.btn_EditDocente = new System.Windows.Forms.Button();
            this.btn_AddDocente = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgView_UC = new System.Windows.Forms.DataGridView();
            this.dgView_Docente = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_DocenteDetalhe = new System.Windows.Forms.TabPage();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dTimeP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.tb_ExtensaoDocente = new System.Windows.Forms.TextBox();
            this.tb_SalarioDocente = new System.Windows.Forms.TextBox();
            this.tb_TelefoneDocente = new System.Windows.Forms.TextBox();
            this.tb_EmailDocente = new System.Windows.Forms.TextBox();
            this.tb_Apelido = new System.Windows.Forms.TextBox();
            this.tb_NomeDocente = new System.Windows.Forms.TextBox();
            this.tb_NumeroDocente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_DocenteLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Docente)).BeginInit();
            this.tab_DocenteDetalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 83);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(737, 27);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 25);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Docentes";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_DocenteLista);
            this.tabControl1.Controls.Add(this.tab_DocenteDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 364);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_DocenteLista
            // 
            this.tab_DocenteLista.Controls.Add(this.btn_DeleteDocente);
            this.tab_DocenteLista.Controls.Add(this.btn_EditDocente);
            this.tab_DocenteLista.Controls.Add(this.btn_AddDocente);
            this.tab_DocenteLista.Controls.Add(this.btn_Search);
            this.tab_DocenteLista.Controls.Add(this.label3);
            this.tab_DocenteLista.Controls.Add(this.dgView_UC);
            this.tab_DocenteLista.Controls.Add(this.dgView_Docente);
            this.tab_DocenteLista.Controls.Add(this.tb_Search);
            this.tab_DocenteLista.Controls.Add(this.label2);
            this.tab_DocenteLista.Location = new System.Drawing.Point(4, 24);
            this.tab_DocenteLista.Name = "tab_DocenteLista";
            this.tab_DocenteLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DocenteLista.Size = new System.Drawing.Size(791, 336);
            this.tab_DocenteLista.TabIndex = 0;
            this.tab_DocenteLista.Text = "Docente Lista";
            this.tab_DocenteLista.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteDocente
            // 
            this.btn_DeleteDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteDocente.Location = new System.Drawing.Point(676, 150);
            this.btn_DeleteDocente.Name = "btn_DeleteDocente";
            this.btn_DeleteDocente.Size = new System.Drawing.Size(109, 44);
            this.btn_DeleteDocente.TabIndex = 8;
            this.btn_DeleteDocente.Text = "Deletar";
            this.btn_DeleteDocente.UseVisualStyleBackColor = true;
            // 
            // btn_EditDocente
            // 
            this.btn_EditDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditDocente.Location = new System.Drawing.Point(676, 104);
            this.btn_EditDocente.Name = "btn_EditDocente";
            this.btn_EditDocente.Size = new System.Drawing.Size(112, 40);
            this.btn_EditDocente.TabIndex = 7;
            this.btn_EditDocente.Text = "Editar";
            this.btn_EditDocente.UseVisualStyleBackColor = true;
            // 
            // btn_AddDocente
            // 
            this.btn_AddDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddDocente.Location = new System.Drawing.Point(676, 56);
            this.btn_AddDocente.Name = "btn_AddDocente";
            this.btn_AddDocente.Size = new System.Drawing.Size(112, 42);
            this.btn_AddDocente.TabIndex = 6;
            this.btn_AddDocente.Text = "Adicionar";
            this.btn_AddDocente.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(539, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(131, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "UCs do Docente:";
            // 
            // dgView_UC
            // 
            this.dgView_UC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView_UC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_UC.Location = new System.Drawing.Point(363, 56);
            this.dgView_UC.Name = "dgView_UC";
            this.dgView_UC.RowTemplate.Height = 25;
            this.dgView_UC.Size = new System.Drawing.Size(307, 277);
            this.dgView_UC.TabIndex = 3;
            // 
            // dgView_Docente
            // 
            this.dgView_Docente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView_Docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Docente.Location = new System.Drawing.Point(3, 38);
            this.dgView_Docente.Name = "dgView_Docente";
            this.dgView_Docente.RowTemplate.Height = 25;
            this.dgView_Docente.Size = new System.Drawing.Size(354, 295);
            this.dgView_Docente.TabIndex = 2;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(111, 9);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(409, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Docente:";
            // 
            // tab_DocenteDetalhe
            // 
            this.tab_DocenteDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_DocenteDetalhe.Controls.Add(this.btn_Save);
            this.tab_DocenteDetalhe.Controls.Add(this.dTimeP_DataNascimento);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_ExtensaoDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_SalarioDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_TelefoneDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_EmailDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_Apelido);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_NomeDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.tb_NumeroDocente);
            this.tab_DocenteDetalhe.Controls.Add(this.label11);
            this.tab_DocenteDetalhe.Controls.Add(this.label10);
            this.tab_DocenteDetalhe.Controls.Add(this.label9);
            this.tab_DocenteDetalhe.Controls.Add(this.label8);
            this.tab_DocenteDetalhe.Controls.Add(this.label7);
            this.tab_DocenteDetalhe.Controls.Add(this.label6);
            this.tab_DocenteDetalhe.Controls.Add(this.label5);
            this.tab_DocenteDetalhe.Controls.Add(this.label4);
            this.tab_DocenteDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_DocenteDetalhe.Name = "tab_DocenteDetalhe";
            this.tab_DocenteDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DocenteDetalhe.Size = new System.Drawing.Size(791, 336);
            this.tab_DocenteDetalhe.TabIndex = 1;
            this.tab_DocenteDetalhe.Text = "Docente Detalhe";
            this.tab_DocenteDetalhe.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(682, 277);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 38);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(588, 277);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 38);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // dTimeP_DataNascimento
            // 
            this.dTimeP_DataNascimento.Location = new System.Drawing.Point(26, 150);
            this.dTimeP_DataNascimento.Name = "dTimeP_DataNascimento";
            this.dTimeP_DataNascimento.Size = new System.Drawing.Size(200, 23);
            this.dTimeP_DataNascimento.TabIndex = 15;
            // 
            // tb_ExtensaoDocente
            // 
            this.tb_ExtensaoDocente.Location = new System.Drawing.Point(239, 277);
            this.tb_ExtensaoDocente.Name = "tb_ExtensaoDocente";
            this.tb_ExtensaoDocente.Size = new System.Drawing.Size(100, 23);
            this.tb_ExtensaoDocente.TabIndex = 14;
            // 
            // tb_SalarioDocente
            // 
            this.tb_SalarioDocente.Location = new System.Drawing.Point(26, 277);
            this.tb_SalarioDocente.Name = "tb_SalarioDocente";
            this.tb_SalarioDocente.Size = new System.Drawing.Size(100, 23);
            this.tb_SalarioDocente.TabIndex = 13;
            // 
            // tb_TelefoneDocente
            // 
            this.tb_TelefoneDocente.Location = new System.Drawing.Point(239, 210);
            this.tb_TelefoneDocente.Name = "tb_TelefoneDocente";
            this.tb_TelefoneDocente.Size = new System.Drawing.Size(185, 23);
            this.tb_TelefoneDocente.TabIndex = 12;
            // 
            // tb_EmailDocente
            // 
            this.tb_EmailDocente.Location = new System.Drawing.Point(26, 212);
            this.tb_EmailDocente.Name = "tb_EmailDocente";
            this.tb_EmailDocente.Size = new System.Drawing.Size(174, 23);
            this.tb_EmailDocente.TabIndex = 11;
            // 
            // tb_Apelido
            // 
            this.tb_Apelido.Location = new System.Drawing.Point(239, 96);
            this.tb_Apelido.Name = "tb_Apelido";
            this.tb_Apelido.Size = new System.Drawing.Size(185, 23);
            this.tb_Apelido.TabIndex = 10;
            // 
            // tb_NomeDocente
            // 
            this.tb_NomeDocente.Location = new System.Drawing.Point(28, 96);
            this.tb_NomeDocente.Name = "tb_NomeDocente";
            this.tb_NomeDocente.Size = new System.Drawing.Size(172, 23);
            this.tb_NomeDocente.TabIndex = 9;
            // 
            // tb_NumeroDocente
            // 
            this.tb_NumeroDocente.Location = new System.Drawing.Point(28, 47);
            this.tb_NumeroDocente.Name = "tb_NumeroDocente";
            this.tb_NumeroDocente.Size = new System.Drawing.Size(100, 23);
            this.tb_NumeroDocente.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Salario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Extensao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Data de Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Apelido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero";
            // 
            // DocenteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "DocenteView";
            this.Text = "DocenteView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_DocenteLista.ResumeLayout(false);
            this.tab_DocenteLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_UC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Docente)).EndInit();
            this.tab_DocenteDetalhe.ResumeLayout(false);
            this.tab_DocenteDetalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_DocenteLista;
        private Label label3;
        private DataGridView dgView_UC;
        private DataGridView dgView_Docente;
        private TextBox tb_Search;
        private Label label2;
        private TabPage tab_DocenteDetalhe;
        private Button btn_Search;
        private Button btn_DeleteDocente;
        private Button btn_EditDocente;
        private Button btn_AddDocente;
        private Label label4;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tb_ExtensaoDocente;
        private TextBox tb_SalarioDocente;
        private TextBox tb_TelefoneDocente;
        private TextBox tb_EmailDocente;
        private TextBox tb_Apelido;
        private TextBox tb_NomeDocente;
        private TextBox tb_NumeroDocente;
        private DateTimePicker dTimeP_DataNascimento;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}