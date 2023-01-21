namespace EscolaDBWinForm.View
{
    partial class EstadoEpocaView
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
            this.tab_EEpocaLista = new System.Windows.Forms.TabPage();
            this.btn_InscricaoRouter = new System.Windows.Forms.Button();
            this.dgView_Inscricoes = new System.Windows.Forms.DataGridView();
            this.dgView_EEpoca = new System.Windows.Forms.DataGridView();
            this.btn_DeleteEEpoca = new System.Windows.Forms.Button();
            this.btn_EditEEpoca = new System.Windows.Forms.Button();
            this.btn_AddEEpoca = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_EEpocaDetalhe = new System.Windows.Forms.TabPage();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_DescricaoEEpoca = new System.Windows.Forms.TextBox();
            this.tb_IdEEpoca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_EEpocaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Inscricoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_EEpoca)).BeginInit();
            this.tab_EEpocaDetalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 76);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(801, 25);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(34, 27);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado de Epocas";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_EEpocaLista);
            this.tabControl1.Controls.Add(this.tab_EEpocaDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(1, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_EEpocaLista
            // 
            this.tab_EEpocaLista.Controls.Add(this.btn_InscricaoRouter);
            this.tab_EEpocaLista.Controls.Add(this.dgView_Inscricoes);
            this.tab_EEpocaLista.Controls.Add(this.dgView_EEpoca);
            this.tab_EEpocaLista.Controls.Add(this.btn_DeleteEEpoca);
            this.tab_EEpocaLista.Controls.Add(this.btn_EditEEpoca);
            this.tab_EEpocaLista.Controls.Add(this.btn_AddEEpoca);
            this.tab_EEpocaLista.Controls.Add(this.btn_Search);
            this.tab_EEpocaLista.Controls.Add(this.tb_Search);
            this.tab_EEpocaLista.Controls.Add(this.label2);
            this.tab_EEpocaLista.Location = new System.Drawing.Point(4, 24);
            this.tab_EEpocaLista.Name = "tab_EEpocaLista";
            this.tab_EEpocaLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EEpocaLista.Size = new System.Drawing.Size(847, 360);
            this.tab_EEpocaLista.TabIndex = 0;
            this.tab_EEpocaLista.Text = "Estado Lista";
            this.tab_EEpocaLista.UseVisualStyleBackColor = true;
            // 
            // btn_InscricaoRouter
            // 
            this.btn_InscricaoRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InscricaoRouter.Location = new System.Drawing.Point(725, 250);
            this.btn_InscricaoRouter.Name = "btn_InscricaoRouter";
            this.btn_InscricaoRouter.Size = new System.Drawing.Size(119, 38);
            this.btn_InscricaoRouter.TabIndex = 8;
            this.btn_InscricaoRouter.Text = "Inscricoes";
            this.btn_InscricaoRouter.UseVisualStyleBackColor = true;
            // 
            // dgView_Inscricoes
            // 
            this.dgView_Inscricoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView_Inscricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Inscricoes.Location = new System.Drawing.Point(3, 196);
            this.dgView_Inscricoes.Name = "dgView_Inscricoes";
            this.dgView_Inscricoes.RowTemplate.Height = 25;
            this.dgView_Inscricoes.Size = new System.Drawing.Size(716, 168);
            this.dgView_Inscricoes.TabIndex = 7;
            // 
            // dgView_EEpoca
            // 
            this.dgView_EEpoca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView_EEpoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_EEpoca.Location = new System.Drawing.Point(3, 38);
            this.dgView_EEpoca.Name = "dgView_EEpoca";
            this.dgView_EEpoca.RowTemplate.Height = 25;
            this.dgView_EEpoca.Size = new System.Drawing.Size(716, 152);
            this.dgView_EEpoca.TabIndex = 6;
            // 
            // btn_DeleteEEpoca
            // 
            this.btn_DeleteEEpoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteEEpoca.Location = new System.Drawing.Point(725, 129);
            this.btn_DeleteEEpoca.Name = "btn_DeleteEEpoca";
            this.btn_DeleteEEpoca.Size = new System.Drawing.Size(119, 42);
            this.btn_DeleteEEpoca.TabIndex = 5;
            this.btn_DeleteEEpoca.Text = "Deletar";
            this.btn_DeleteEEpoca.UseVisualStyleBackColor = true;
            // 
            // btn_EditEEpoca
            // 
            this.btn_EditEEpoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditEEpoca.Location = new System.Drawing.Point(725, 84);
            this.btn_EditEEpoca.Name = "btn_EditEEpoca";
            this.btn_EditEEpoca.Size = new System.Drawing.Size(119, 39);
            this.btn_EditEEpoca.TabIndex = 4;
            this.btn_EditEEpoca.Text = "Editar";
            this.btn_EditEEpoca.UseVisualStyleBackColor = true;
            // 
            // btn_AddEEpoca
            // 
            this.btn_AddEEpoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddEEpoca.Location = new System.Drawing.Point(725, 38);
            this.btn_AddEEpoca.Name = "btn_AddEEpoca";
            this.btn_AddEEpoca.Size = new System.Drawing.Size(119, 40);
            this.btn_AddEEpoca.TabIndex = 3;
            this.btn_AddEEpoca.Text = "Adicionar";
            this.btn_AddEEpoca.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(563, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(162, 9);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(395, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Estados de Epoca:";
            // 
            // tab_EEpocaDetalhe
            // 
            this.tab_EEpocaDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_EEpocaDetalhe.Controls.Add(this.btn_Save);
            this.tab_EEpocaDetalhe.Controls.Add(this.tb_DescricaoEEpoca);
            this.tab_EEpocaDetalhe.Controls.Add(this.tb_IdEEpoca);
            this.tab_EEpocaDetalhe.Controls.Add(this.label4);
            this.tab_EEpocaDetalhe.Controls.Add(this.label3);
            this.tab_EEpocaDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_EEpocaDetalhe.Name = "tab_EEpocaDetalhe";
            this.tab_EEpocaDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EEpocaDetalhe.Size = new System.Drawing.Size(847, 360);
            this.tab_EEpocaDetalhe.TabIndex = 1;
            this.tab_EEpocaDetalhe.Text = "Estado Detalhe";
            this.tab_EEpocaDetalhe.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(729, 285);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 48);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(632, 285);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 48);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // tb_DescricaoEEpoca
            // 
            this.tb_DescricaoEEpoca.Location = new System.Drawing.Point(43, 130);
            this.tb_DescricaoEEpoca.Name = "tb_DescricaoEEpoca";
            this.tb_DescricaoEEpoca.Size = new System.Drawing.Size(496, 23);
            this.tb_DescricaoEEpoca.TabIndex = 3;
            // 
            // tb_IdEEpoca
            // 
            this.tb_IdEEpoca.Location = new System.Drawing.Point(43, 56);
            this.tb_IdEEpoca.Name = "tb_IdEEpoca";
            this.tb_IdEEpoca.Size = new System.Drawing.Size(105, 23);
            this.tb_IdEEpoca.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // EstadoEpocaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "EstadoEpocaView";
            this.Text = "EstadoEpocaView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_EEpocaLista.ResumeLayout(false);
            this.tab_EEpocaLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Inscricoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_EEpoca)).EndInit();
            this.tab_EEpocaDetalhe.ResumeLayout(false);
            this.tab_EEpocaDetalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_EEpocaLista;
        private DataGridView dgView_EEpoca;
        private Button btn_DeleteEEpoca;
        private Button btn_EditEEpoca;
        private Button btn_AddEEpoca;
        private Button btn_Search;
        private TextBox tb_Search;
        private Label label2;
        private TabPage tab_EEpocaDetalhe;
        private Button btn_Cancel;
        private Button btn_Save;
        private TextBox tb_DescricaoEEpoca;
        private TextBox tb_IdEEpoca;
        private Label label4;
        private Label label3;
        private Button btn_InscricaoRouter;
        private DataGridView dgView_Inscricoes;
    }
}