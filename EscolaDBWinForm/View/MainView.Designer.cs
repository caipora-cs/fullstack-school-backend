namespace EscolaDBWinForm.View
{
    partial class MainView
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
            this.btn_AlunosView = new System.Windows.Forms.Button();
            this.btn_CursosView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CursosView);
            this.panel1.Controls.Add(this.btn_AlunosView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_AlunosView
            // 
            this.btn_AlunosView.Location = new System.Drawing.Point(0, 61);
            this.btn_AlunosView.Name = "btn_AlunosView";
            this.btn_AlunosView.Size = new System.Drawing.Size(200, 47);
            this.btn_AlunosView.TabIndex = 0;
            this.btn_AlunosView.Text = "Alunos";
            this.btn_AlunosView.UseVisualStyleBackColor = true;
            // 
            // btn_CursosView
            // 
            this.btn_CursosView.Location = new System.Drawing.Point(0, 104);
            this.btn_CursosView.Name = "btn_CursosView";
            this.btn_CursosView.Size = new System.Drawing.Size(200, 51);
            this.btn_CursosView.TabIndex = 1;
            this.btn_CursosView.Text = "Cursos";
            this.btn_CursosView.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_AlunosView;
        private Button btn_CursosView;
    }
}