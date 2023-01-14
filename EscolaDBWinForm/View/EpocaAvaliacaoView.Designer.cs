namespace EscolaDBWinForm.View
{
    partial class EpocaAvaliacaoView
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
            this.tab_EpocaALista = new System.Windows.Forms.TabPage();
            this.tab_EpocaADetalhe = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgView_EpocaA = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddEpocaA = new System.Windows.Forms.Button();
            this.btn_EditEpocaA = new System.Windows.Forms.Button();
            this.btn_DeleteEpocaA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IdEpocaA = new System.Windows.Forms.TextBox();
            this.tb_DescricaoEpocaA = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_EpocaALista.SuspendLayout();
            this.tab_EpocaADetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_EpocaA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Epocas de Avaliacao";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(764, 29);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 27);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_EpocaALista);
            this.tabControl1.Controls.Add(this.tab_EpocaADetalhe);
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_EpocaALista
            // 
            this.tab_EpocaALista.Controls.Add(this.btn_DeleteEpocaA);
            this.tab_EpocaALista.Controls.Add(this.btn_EditEpocaA);
            this.tab_EpocaALista.Controls.Add(this.btn_AddEpocaA);
            this.tab_EpocaALista.Controls.Add(this.btn_Search);
            this.tab_EpocaALista.Controls.Add(this.dgView_EpocaA);
            this.tab_EpocaALista.Controls.Add(this.tb_Search);
            this.tab_EpocaALista.Controls.Add(this.label2);
            this.tab_EpocaALista.Location = new System.Drawing.Point(4, 24);
            this.tab_EpocaALista.Name = "tab_EpocaALista";
            this.tab_EpocaALista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EpocaALista.Size = new System.Drawing.Size(814, 358);
            this.tab_EpocaALista.TabIndex = 0;
            this.tab_EpocaALista.Text = "Epoca Lista";
            this.tab_EpocaALista.UseVisualStyleBackColor = true;
            // 
            // tab_EpocaADetalhe
            // 
            this.tab_EpocaADetalhe.Controls.Add(this.btn_Cancel);
            this.tab_EpocaADetalhe.Controls.Add(this.btn_Save);
            this.tab_EpocaADetalhe.Controls.Add(this.tb_DescricaoEpocaA);
            this.tab_EpocaADetalhe.Controls.Add(this.tb_IdEpocaA);
            this.tab_EpocaADetalhe.Controls.Add(this.label4);
            this.tab_EpocaADetalhe.Controls.Add(this.label3);
            this.tab_EpocaADetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_EpocaADetalhe.Name = "tab_EpocaADetalhe";
            this.tab_EpocaADetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EpocaADetalhe.Size = new System.Drawing.Size(814, 358);
            this.tab_EpocaADetalhe.TabIndex = 1;
            this.tab_EpocaADetalhe.Text = "Epoca Detalhe";
            this.tab_EpocaADetalhe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Epocas:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(109, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(431, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // dgView_EpocaA
            // 
            this.dgView_EpocaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_EpocaA.Location = new System.Drawing.Point(0, 39);
            this.dgView_EpocaA.Name = "dgView_EpocaA";
            this.dgView_EpocaA.RowTemplate.Height = 25;
            this.dgView_EpocaA.Size = new System.Drawing.Size(683, 323);
            this.dgView_EpocaA.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(546, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_AddEpocaA
            // 
            this.btn_AddEpocaA.Location = new System.Drawing.Point(689, 39);
            this.btn_AddEpocaA.Name = "btn_AddEpocaA";
            this.btn_AddEpocaA.Size = new System.Drawing.Size(122, 41);
            this.btn_AddEpocaA.TabIndex = 4;
            this.btn_AddEpocaA.Text = "Adicionar";
            this.btn_AddEpocaA.UseVisualStyleBackColor = true;
            // 
            // btn_EditEpocaA
            // 
            this.btn_EditEpocaA.Location = new System.Drawing.Point(689, 86);
            this.btn_EditEpocaA.Name = "btn_EditEpocaA";
            this.btn_EditEpocaA.Size = new System.Drawing.Size(122, 43);
            this.btn_EditEpocaA.TabIndex = 5;
            this.btn_EditEpocaA.Text = "Editar";
            this.btn_EditEpocaA.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteEpocaA
            // 
            this.btn_DeleteEpocaA.Location = new System.Drawing.Point(689, 135);
            this.btn_DeleteEpocaA.Name = "btn_DeleteEpocaA";
            this.btn_DeleteEpocaA.Size = new System.Drawing.Size(122, 44);
            this.btn_DeleteEpocaA.TabIndex = 6;
            this.btn_DeleteEpocaA.Text = "Deletar";
            this.btn_DeleteEpocaA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descricao";
            // 
            // tb_IdEpocaA
            // 
            this.tb_IdEpocaA.Location = new System.Drawing.Point(39, 55);
            this.tb_IdEpocaA.Name = "tb_IdEpocaA";
            this.tb_IdEpocaA.Size = new System.Drawing.Size(100, 23);
            this.tb_IdEpocaA.TabIndex = 2;
            // 
            // tb_DescricaoEpocaA
            // 
            this.tb_DescricaoEpocaA.Location = new System.Drawing.Point(39, 129);
            this.tb_DescricaoEpocaA.Name = "tb_DescricaoEpocaA";
            this.tb_DescricaoEpocaA.Size = new System.Drawing.Size(448, 23);
            this.tb_DescricaoEpocaA.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(628, 290);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 48);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(709, 290);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 48);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // EpocaAvaliacaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "EpocaAvaliacaoView";
            this.Text = "EpocaAvaliacaoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_EpocaALista.ResumeLayout(false);
            this.tab_EpocaALista.PerformLayout();
            this.tab_EpocaADetalhe.ResumeLayout(false);
            this.tab_EpocaADetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_EpocaA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Close;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_EpocaALista;
        private Button btn_DeleteEpocaA;
        private Button btn_EditEpocaA;
        private Button btn_AddEpocaA;
        private Button btn_Search;
        private DataGridView dgView_EpocaA;
        private TextBox tb_Search;
        private Label label2;
        private TabPage tab_EpocaADetalhe;
        private Label label3;
        private TextBox tb_DescricaoEpocaA;
        private TextBox tb_IdEpocaA;
        private Label label4;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}