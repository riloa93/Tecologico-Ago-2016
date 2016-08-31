namespace _9_Reinas
{
    partial class frmPal
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
            this.grdSoluciones = new System.Windows.Forms.DataGridView();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posiciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResul = new System.Windows.Forms.Label();
            this.grdReinas = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtCiclos = new System.Windows.Forms.TextBox();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReinas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.grdSoluciones);
            this.panel1.Controls.Add(this.lblResul);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 244);
            this.panel1.TabIndex = 0;
            // 
            // grdSoluciones
            // 
            this.grdSoluciones.AllowUserToAddRows = false;
            this.grdSoluciones.AllowUserToDeleteRows = false;
            this.grdSoluciones.BackgroundColor = System.Drawing.Color.Bisque;
            this.grdSoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solucion,
            this.Posiciones});
            this.grdSoluciones.Location = new System.Drawing.Point(3, 42);
            this.grdSoluciones.Name = "grdSoluciones";
            this.grdSoluciones.ReadOnly = true;
            this.grdSoluciones.Size = new System.Drawing.Size(243, 195);
            this.grdSoluciones.TabIndex = 1;
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solucion";
            this.Solucion.Name = "Solucion";
            this.Solucion.ReadOnly = true;
            // 
            // Posiciones
            // 
            this.Posiciones.HeaderText = "Posiciones";
            this.Posiciones.Name = "Posiciones";
            this.Posiciones.ReadOnly = true;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResul.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(70, 13);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(113, 26);
            this.lblResul.TabIndex = 0;
            this.lblResul.Text = "Soluciones:";
            // 
            // grdReinas
            // 
            this.grdReinas.AllowUserToAddRows = false;
            this.grdReinas.AllowUserToDeleteRows = false;
            this.grdReinas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdReinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.F,
            this.G,
            this.H,
            this.I});
            this.grdReinas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdReinas.Location = new System.Drawing.Point(269, 12);
            this.grdReinas.Name = "grdReinas";
            this.grdReinas.RowHeadersWidth = 30;
            this.grdReinas.Size = new System.Drawing.Size(704, 244);
            this.grdReinas.TabIndex = 1;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.Width = 80;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.Width = 80;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.Width = 80;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.Width = 80;
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.Width = 80;
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.Width = 80;
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.Width = 80;
            // 
            // I
            // 
            this.I.HeaderText = "I";
            this.I.Name = "I";
            this.I.Width = 80;
            // 
            // btnComenzar
            // 
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(863, 262);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(95, 37);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comienza";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtCiclos
            // 
            this.txtCiclos.Location = new System.Drawing.Point(760, 272);
            this.txtCiclos.Name = "txtCiclos";
            this.txtCiclos.Size = new System.Drawing.Size(93, 20);
            this.txtCiclos.TabIndex = 3;
            this.txtCiclos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.Location = new System.Drawing.Point(604, 274);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(150, 18);
            this.lblIteraciones.TabIndex = 4;
            this.lblIteraciones.Text = "Cantidad de iteraciones";
            // 
            // frmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(991, 307);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.txtCiclos);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.grdReinas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9 Reinas Inteligencia Artificial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdSoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posiciones;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.DataGridView grdReinas;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtCiclos;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
    }
}

