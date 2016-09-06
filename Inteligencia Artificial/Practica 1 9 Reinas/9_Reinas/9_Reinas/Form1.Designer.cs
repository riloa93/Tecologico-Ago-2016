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
            this.lsbSoluciones = new System.Windows.Forms.ListBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.grdReinas = new System.Windows.Forms.DataGridView();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.pgrbTarea = new System.Windows.Forms.ProgressBar();
            this.bgrdWTarea = new System.ComponentModel.BackgroundWorker();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReinas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lsbSoluciones);
            this.panel1.Controls.Add(this.lblResul);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 244);
            this.panel1.TabIndex = 0;
            // 
            // lsbSoluciones
            // 
            this.lsbSoluciones.BackColor = System.Drawing.Color.Bisque;
            this.lsbSoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbSoluciones.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSoluciones.FormattingEnabled = true;
            this.lsbSoluciones.ItemHeight = 21;
            this.lsbSoluciones.Location = new System.Drawing.Point(3, 27);
            this.lsbSoluciones.Name = "lsbSoluciones";
            this.lsbSoluciones.Size = new System.Drawing.Size(241, 210);
            this.lsbSoluciones.TabIndex = 1;
            this.lsbSoluciones.SelectedIndexChanged += new System.EventHandler(this.lsbSoluciones_SelectedIndexChanged);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResul.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(70, 3);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(113, 26);
            this.lblResul.TabIndex = 0;
            this.lblResul.Text = "Soluciones:";
            // 
            // grdReinas
            // 
            this.grdReinas.AllowUserToAddRows = false;
            this.grdReinas.AllowUserToDeleteRows = false;
            this.grdReinas.AllowUserToResizeColumns = false;
            this.grdReinas.AllowUserToResizeRows = false;
            this.grdReinas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdReinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.grdReinas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdReinas.Location = new System.Drawing.Point(269, 22);
            this.grdReinas.Name = "grdReinas";
            this.grdReinas.RowHeadersWidth = 30;
            this.grdReinas.Size = new System.Drawing.Size(432, 222);
            this.grdReinas.TabIndex = 1;
            this.grdReinas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdReinas_RowPostPaint);
            // 
            // btnComenzar
            // 
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(309, 265);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(95, 37);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comienza";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pgrbTarea
            // 
            this.pgrbTarea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgrbTarea.Location = new System.Drawing.Point(0, 315);
            this.pgrbTarea.Name = "pgrbTarea";
            this.pgrbTarea.Size = new System.Drawing.Size(712, 21);
            this.pgrbTarea.TabIndex = 3;
            // 
            // bgrdWTarea
            // 
            this.bgrdWTarea.WorkerReportsProgress = true;
            this.bgrdWTarea.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgrdWTarea_DoWork);
            this.bgrdWTarea.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgrdWTarea_ProgressChanged);
            this.bgrdWTarea.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgrdWTarea_RunWorkerCompleted);
            // 
            // A
            // 
            this.A.FillWeight = 50F;
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 50;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 50;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 50;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 50;
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Width = 50;
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 50;
            // 
            // I
            // 
            this.I.HeaderText = "I";
            this.I.Name = "I";
            this.I.ReadOnly = true;
            this.I.Width = 50;
            // 
            // frmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(712, 336);
            this.Controls.Add(this.pgrbTarea);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.grdReinas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9 Reinas Inteligencia Artificial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.DataGridView grdReinas;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.ListBox lsbSoluciones;
        private System.Windows.Forms.ProgressBar pgrbTarea;
        private System.ComponentModel.BackgroundWorker bgrdWTarea;
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

