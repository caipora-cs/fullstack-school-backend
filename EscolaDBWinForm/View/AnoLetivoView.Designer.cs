namespace EscolaDBWinForm.View
{
    partial class AnoLetivoView
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
            this.tab_AnoLista = new System.Windows.Forms.TabPage();
            this.tab_AnoDetalhe = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgView_Ano = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddAno = new System.Windows.Forms.Button();
            this.btn_EditAno = new System.Windows.Forms.Button();
            this.btn_DeleteAno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_IdAno = new System.Windows.Forms.TextBox();
            this.tb_AnoInicial = new System.Windows.Forms.TextBox();
            this.tb_AnoFinal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_AnoLista.SuspendLayout();
            this.tab_AnoDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Ano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ano Letivo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_AnoLista);
            this.tabControl1.Controls.Add(this.tab_AnoDetalhe);
            this.tabControl1.Location = new System.Drawing.Point(1, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 368);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_AnoLista
            // 
            this.tab_AnoLista.Controls.Add(this.btn_DeleteAno);
            this.tab_AnoLista.Controls.Add(this.btn_EditAno);
            this.tab_AnoLista.Controls.Add(this.btn_AddAno);
            this.tab_AnoLista.Controls.Add(this.btn_Search);
            this.tab_AnoLista.Controls.Add(this.dgView_Ano);
            this.tab_AnoLista.Controls.Add(this.tb_Search);
            this.tab_AnoLista.Controls.Add(this.label2);
            this.tab_AnoLista.Location = new System.Drawing.Point(4, 24);
            this.tab_AnoLista.Name = "tab_AnoLista";
            this.tab_AnoLista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AnoLista.Size = new System.Drawing.Size(789, 340);
            this.tab_AnoLista.TabIndex = 0;
            this.tab_AnoLista.Text = "Ano Lista";
            this.tab_AnoLista.UseVisualStyleBackColor = true;
            // 
            // tab_AnoDetalhe
            // 
            this.tab_AnoDetalhe.Controls.Add(this.tb_AnoFinal);
            this.tab_AnoDetalhe.Controls.Add(this.tb_AnoInicial);
            this.tab_AnoDetalhe.Controls.Add(this.tb_IdAno);
            this.tab_AnoDetalhe.Controls.Add(this.btn_Cancel);
            this.tab_AnoDetalhe.Controls.Add(this.btn_Save);
            this.tab_AnoDetalhe.Controls.Add(this.label5);
            this.tab_AnoDetalhe.Controls.Add(this.label4);
            this.tab_AnoDetalhe.Controls.Add(this.label3);
            this.tab_AnoDetalhe.Location = new System.Drawing.Point(4, 24);
            this.tab_AnoDetalhe.Name = "tab_AnoDetalhe";
            this.tab_AnoDetalhe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_AnoDetalhe.Size = new System.Drawing.Size(789, 340);
            this.tab_AnoDetalhe.TabIndex = 1;
            this.tab_AnoDetalhe.Text = "Ano Detalhe";
            this.tab_AnoDetalhe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar Ano Letivo:";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(128, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(430, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // dgView_Ano
            // 
            this.dgView_Ano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Ano.Location = new System.Drawing.Point(6, 39);
            this.dgView_Ano.Name = "dgView_Ano";
            this.dgView_Ano.RowTemplate.Height = 25;
            this.dgView_Ano.Size = new System.Drawing.Size(666, 298);
            this.dgView_Ano.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(564, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Procurar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_AddAno
            // 
            this.btn_AddAno.Location = new System.Drawing.Point(678, 39);
            this.btn_AddAno.Name = "btn_AddAno";
            this.btn_AddAno.Size = new System.Drawing.Size(108, 39);
            this.btn_AddAno.TabIndex = 4;
            this.btn_AddAno.Text = "Adicionar";
            this.btn_AddAno.UseVisualStyleBackColor = true;
            // 
            // btn_EditAno
            // 
            this.btn_EditAno.Location = new System.Drawing.Point(678, 84);
            this.btn_EditAno.Name = "btn_EditAno";
            this.btn_EditAno.Size = new System.Drawing.Size(108, 40);
            this.btn_EditAno.TabIndex = 5;
            this.btn_EditAno.Text = "Editar";
            this.btn_EditAno.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteAno
            // 
            this.btn_DeleteAno.Location = new System.Drawing.Point(678, 130);
            this.btn_DeleteAno.Name = "btn_DeleteAno";
            this.btn_DeleteAno.Size = new System.Drawing.Size(108, 41);
            this.btn_DeleteAno.TabIndex = 6;
            this.btn_DeleteAno.Text = "Deletar";
            this.btn_DeleteAno.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ano Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ano Final";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(737, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(603, 275);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 39);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(684, 275);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 39);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // tb_IdAno
            // 
            this.tb_IdAno.Location = new System.Drawing.Point(26, 42);
            this.tb_IdAno.Name = "tb_IdAno";
            this.tb_IdAno.Size = new System.Drawing.Size(100, 23);
            this.tb_IdAno.TabIndex = 5;
            // 
            // tb_AnoInicial
            // 
            this.tb_AnoInicial.Location = new System.Drawing.Point(26, 111);
            this.tb_AnoInicial.Name = "tb_AnoInicial";
            this.tb_AnoInicial.Size = new System.Drawing.Size(100, 23);
            this.tb_AnoInicial.TabIndex = 6;
            // 
            // tb_AnoFinal
            // 
            this.tb_AnoFinal.Location = new System.Drawing.Point(149, 111);
            this.tb_AnoFinal.Name = "tb_AnoFinal";
            this.tb_AnoFinal.Size = new System.Drawing.Size(100, 23);
            this.tb_AnoFinal.TabIndex = 7;
            // 
            // AnoLetivoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AnoLetivoView";
            this.Text = "AnoLetivoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_AnoLista.ResumeLayout(false);
            this.tab_AnoLista.PerformLayout();
            this.tab_AnoDetalhe.ResumeLayout(false);
            this.tab_AnoDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Ano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_AnoLista;
        private Button btn_DeleteAno;
        private Button btn_EditAno;
        private Button btn_AddAno;
        private Button btn_Search;
        private DataGridView dgView_Ano;
        private TextBox tb_Search;
        private Label label2;
        private TabPage tab_AnoDetalhe;
        private TextBox tb_AnoFinal;
        private TextBox tb_AnoInicial;
        private TextBox tb_IdAno;
        private Button btn_Cancel;
        private Button btn_Save;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}