namespace EscolaDBWinForm.View
{
    partial class InscricaoView
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
            this.tab_InscricaoLista = new System.Windows.Forms.TabPage();
            this.tab_InscricaoDetalhe = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgView_Inscricao = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddInscricao = new System.Windows.Forms.Button();
            this.btn_EditInscricao = new System.Windows.Forms.Button();
            this.btn_DeleteInscricao = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_NumeroAlunoInscricao = new System.Windows.Forms.TextBox();
            this.cb_UCInscricao = new System.Windows.Forms.ComboBox();
            this.cb_AnoInscricao = new System.Windows.Forms.ComboBox();
            this.cb_EpocaAInscricao = new System.Windows.Forms.ComboBox();
            this.cb_EEpocaInscricao = new System.Windows.Forms.ComboBox();
            this.tb_PresencaInscricao = new System.Windows.Forms.TextBox();
            this.tb_NotaInscricao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_InscricaoLista.SuspendLayout();
            this.tab_InscricaoDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Inscricao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscricoes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_InscricaoLista);
            this.tabControl1.Controls.Add(this.tab_InscricaoDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_InscricaoLista
            // 
            this.tab_InscricaoLista.Controls.Add(this.btn_DeleteInscricao);
            this.tab_InscricaoLista.Controls.Add(this.btn_EditInscricao);
            this.tab_InscricaoLista.Controls.Add(this.btn_AddInscricao);
            this.tab_InscricaoLista.Controls.Add(this.btn_Search);
            this.tab_InscricaoLista.Controls.Add(this.dgView_Inscricao);
            this.tab_InscricaoLista.Controls.Add(this.tb_Search);
            this.tab_InscricaoLista.Controls.Add(this.label2);
            this.tab_InscricaoLista.Location = new System.Drawing.Point(4, 24);
            this.tab_InscricaoLista.Name = "tab_InscricaoLista";
            this.tab_InscricaoLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InscricaoLista.Size = new System.Drawing.Size(845, 372);
            this.tab_InscricaoLista.TabIndex = 0;
            this.tab_InscricaoLista.Text = "Inscricoes Lista";
            this.tab_InscricaoLista.UseVisualStyleBackColor = true;
            // 
            // tab_InscricaoDetalhe
            // 
            this.tab_InscricaoDetalhe.Controls.Add(this.tb_NotaInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.tb_PresencaInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.cb_EEpocaInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.cb_EpocaAInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.cb_AnoInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.cb_UCInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.tb_NumeroAlunoInscricao);
            this.tab_InscricaoDetalhe.Controls.Add(this.label9);
            this.tab_InscricaoDetalhe.Controls.Add(this.label8);
            this.tab_InscricaoDetalhe.Controls.Add(this.label7);
            this.tab_InscricaoDetalhe.Controls.Add(this.label6);
            this.tab_InscricaoDetalhe.Controls.Add(this.label5);
            this.tab_InscricaoDetalhe.Controls.Add(this.label4);
            this.tab_InscricaoDetalhe.Controls.Add(this.label3);
            this.tab_InscricaoDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_InscricaoDetalhe.Name = "tab_InscricaoDetalhe";
            this.tab_InscricaoDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InscricaoDetalhe.Size = new System.Drawing.Size(845, 372);
            this.tab_InscricaoDetalhe.TabIndex = 1;
            this.tab_InscricaoDetalhe.Text = "Inscricoes Detalhe";
            this.tab_InscricaoDetalhe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Inscricao:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(114, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(467, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // dgView_Inscricao
            // 
            this.dgView_Inscricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Inscricao.Location = new System.Drawing.Point(6, 39);
            this.dgView_Inscricao.Name = "dgView_Inscricao";
            this.dgView_Inscricao.RowTemplate.Height = 25;
            this.dgView_Inscricao.Size = new System.Drawing.Size(723, 333);
            this.dgView_Inscricao.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(587, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_AddInscricao
            // 
            this.btn_AddInscricao.Location = new System.Drawing.Point(735, 39);
            this.btn_AddInscricao.Name = "btn_AddInscricao";
            this.btn_AddInscricao.Size = new System.Drawing.Size(104, 38);
            this.btn_AddInscricao.TabIndex = 4;
            this.btn_AddInscricao.Text = "Adicionar";
            this.btn_AddInscricao.UseVisualStyleBackColor = true;
            // 
            // btn_EditInscricao
            // 
            this.btn_EditInscricao.Location = new System.Drawing.Point(735, 83);
            this.btn_EditInscricao.Name = "btn_EditInscricao";
            this.btn_EditInscricao.Size = new System.Drawing.Size(104, 37);
            this.btn_EditInscricao.TabIndex = 5;
            this.btn_EditInscricao.Text = "Editar";
            this.btn_EditInscricao.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteInscricao
            // 
            this.btn_DeleteInscricao.Location = new System.Drawing.Point(735, 126);
            this.btn_DeleteInscricao.Name = "btn_DeleteInscricao";
            this.btn_DeleteInscricao.Size = new System.Drawing.Size(103, 41);
            this.btn_DeleteInscricao.TabIndex = 6;
            this.btn_DeleteInscricao.Text = "Deletar";
            this.btn_DeleteInscricao.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(789, 24);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(38, 29);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero do Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unidade Curricular (id)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ano Letivo (id)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Epoca Avaliacao(id)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Estado da Epoca(id)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Presenca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nota";
            // 
            // tb_NumeroAlunoInscricao
            // 
            this.tb_NumeroAlunoInscricao.Location = new System.Drawing.Point(22, 41);
            this.tb_NumeroAlunoInscricao.Name = "tb_NumeroAlunoInscricao";
            this.tb_NumeroAlunoInscricao.Size = new System.Drawing.Size(100, 23);
            this.tb_NumeroAlunoInscricao.TabIndex = 7;
            // 
            // cb_UCInscricao
            // 
            this.cb_UCInscricao.FormattingEnabled = true;
            this.cb_UCInscricao.Location = new System.Drawing.Point(22, 93);
            this.cb_UCInscricao.Name = "cb_UCInscricao";
            this.cb_UCInscricao.Size = new System.Drawing.Size(227, 23);
            this.cb_UCInscricao.TabIndex = 8;
            // 
            // cb_AnoInscricao
            // 
            this.cb_AnoInscricao.FormattingEnabled = true;
            this.cb_AnoInscricao.Location = new System.Drawing.Point(22, 144);
            this.cb_AnoInscricao.Name = "cb_AnoInscricao";
            this.cb_AnoInscricao.Size = new System.Drawing.Size(227, 23);
            this.cb_AnoInscricao.TabIndex = 9;
            // 
            // cb_EpocaAInscricao
            // 
            this.cb_EpocaAInscricao.FormattingEnabled = true;
            this.cb_EpocaAInscricao.Location = new System.Drawing.Point(19, 199);
            this.cb_EpocaAInscricao.Name = "cb_EpocaAInscricao";
            this.cb_EpocaAInscricao.Size = new System.Drawing.Size(172, 23);
            this.cb_EpocaAInscricao.TabIndex = 10;
            // 
            // cb_EEpocaInscricao
            // 
            this.cb_EEpocaInscricao.FormattingEnabled = true;
            this.cb_EEpocaInscricao.Location = new System.Drawing.Point(19, 261);
            this.cb_EEpocaInscricao.Name = "cb_EEpocaInscricao";
            this.cb_EEpocaInscricao.Size = new System.Drawing.Size(172, 23);
            this.cb_EEpocaInscricao.TabIndex = 11;
            // 
            // tb_PresencaInscricao
            // 
            this.tb_PresencaInscricao.Location = new System.Drawing.Point(19, 315);
            this.tb_PresencaInscricao.Name = "tb_PresencaInscricao";
            this.tb_PresencaInscricao.Size = new System.Drawing.Size(100, 23);
            this.tb_PresencaInscricao.TabIndex = 12;
            // 
            // tb_NotaInscricao
            // 
            this.tb_NotaInscricao.Location = new System.Drawing.Point(158, 315);
            this.tb_NotaInscricao.Name = "tb_NotaInscricao";
            this.tb_NotaInscricao.Size = new System.Drawing.Size(100, 23);
            this.tb_NotaInscricao.TabIndex = 13;
            // 
            // InscricaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "InscricaoView";
            this.Text = "InscricaoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_InscricaoLista.ResumeLayout(false);
            this.tab_InscricaoLista.PerformLayout();
            this.tab_InscricaoDetalhe.ResumeLayout(false);
            this.tab_InscricaoDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Inscricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_InscricaoLista;
        private Button btn_DeleteInscricao;
        private Button btn_EditInscricao;
        private Button btn_AddInscricao;
        private Button btn_Search;
        private DataGridView dgView_Inscricao;
        private TextBox tb_Search;
        private Label label2;
        private TabPage tab_InscricaoDetalhe;
        private TextBox tb_NotaInscricao;
        private TextBox tb_PresencaInscricao;
        private ComboBox cb_EEpocaInscricao;
        private ComboBox cb_EpocaAInscricao;
        private ComboBox cb_AnoInscricao;
        private ComboBox cb_UCInscricao;
        private TextBox tb_NumeroAlunoInscricao;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}