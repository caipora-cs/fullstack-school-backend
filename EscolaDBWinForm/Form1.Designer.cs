namespace EscolaDBWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Read = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(649, 226);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(161, 67);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Read Students";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(313, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(649, 313);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(150, 74);
            this.btn_AddStudent.TabIndex = 2;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 595);
            this.Controls.Add(this.btn_AddStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Read);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Read;
        private DataGridView dataGridView1;
        private Button btn_AddStudent;
    }
}