namespace Examen_U2
{
    partial class frm_Pal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTablaProbabilidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnProbabilidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProbabilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaProbabilidad
            // 
            this.dgvTablaProbabilidad.AllowUserToAddRows = false;
            this.dgvTablaProbabilidad.AllowUserToDeleteRows = false;
            this.dgvTablaProbabilidad.AllowUserToResizeColumns = false;
            this.dgvTablaProbabilidad.AllowUserToResizeRows = false;
            this.dgvTablaProbabilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablaProbabilidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaProbabilidad.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTablaProbabilidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaProbabilidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaProbabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaProbabilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTablaProbabilidad.Location = new System.Drawing.Point(12, 59);
            this.dgvTablaProbabilidad.Name = "dgvTablaProbabilidad";
            this.dgvTablaProbabilidad.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaProbabilidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaProbabilidad.Size = new System.Drawing.Size(559, 148);
            this.dgvTablaProbabilidad.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 38;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 38;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 38;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 38;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(90, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tabla de probabilidad y preguntas:";
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Items.AddRange(new object[] {
            "Probabilidad de Comer y tener Tifoidea",
            "Probabilidad de Comer y tener No Tifoidea",
            "Probabilidad de Comer, tener Tifoidea y Reacciones",
            "Probabilidad de Comer, No Tener Tifoidea y Tener Reacciones",
            "Probabilidad de tener Tifoidea y Gripe y tener Fiebre",
            "Probabilidad de tener Tifoidea y No tener Gripe y tener Fiebre",
            "Probabilidad de No tener Tifoidea y Tener Gripe y tener Fiebre",
            "Probabilidad de No tener Tifoidea Ni Gripe y tener Fiebre",
            "Probabilidad de Tener Tifoidea y Gripe y Tener Dolor",
            "Probabilidad de Tener Tifoidea y No Gripe y Tener Dolor",
            "Probabilidad de No Tener Tifoidea y Tener Gripe y Tener Dolor",
            "Probabilidad de No Tener Tifoidea Ni Gripe y Tener Dolor"});
            this.cmbPregunta.Location = new System.Drawing.Point(12, 271);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(559, 21);
            this.cmbPregunta.TabIndex = 2;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(146, 241);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(297, 17);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "Selecciona la probabilidad a calcular:";
            // 
            // btnProbabilidad
            // 
            this.btnProbabilidad.Location = new System.Drawing.Point(214, 298);
            this.btnProbabilidad.Name = "btnProbabilidad";
            this.btnProbabilidad.Size = new System.Drawing.Size(131, 23);
            this.btnProbabilidad.TabIndex = 4;
            this.btnProbabilidad.Text = "Calcular";
            this.btnProbabilidad.UseVisualStyleBackColor = true;
            this.btnProbabilidad.Click += new System.EventHandler(this.btnProbabilidad_Click);
            // 
            // frm_Pal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1253, 331);
            this.Controls.Add(this.btnProbabilidad);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvTablaProbabilidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_Pal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Unidad 2 I.A.: Tabla de probabilidad";
            this.Load += new System.EventHandler(this.frm_Pal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Pal_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProbabilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaProbabilidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnProbabilidad;
    }
}

