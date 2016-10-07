namespace Red_Semantica_P2_U2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPal));
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnPregunta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExplicacion.Location = new System.Drawing.Point(34, 12);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(625, 95);
            this.lblExplicacion.TabIndex = 0;
            this.lblExplicacion.Text = resources.GetString("lblExplicacion.Text");
            //this.lblExplicacion.Click += new System.EventHandler(this.lblExplicacion_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(34, 269);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(47, 19);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPregunta);
            this.panel1.Controls.Add(this.txtPregunta);
            this.panel1.Controls.Add(this.lblExplicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 243);
            this.panel1.TabIndex = 2;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(38, 138);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(621, 23);
            this.txtPregunta.TabIndex = 1;
            // 
            // btnPregunta
            // 
            this.btnPregunta.Location = new System.Drawing.Point(288, 180);
            this.btnPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPregunta.Name = "btnPregunta";
            this.btnPregunta.Size = new System.Drawing.Size(94, 46);
            this.btnPregunta.TabIndex = 2;
            this.btnPregunta.Text = "Preguntar";
            this.btnPregunta.UseVisualStyleBackColor = true;
            this.btnPregunta.Click += new System.EventHandler(this.btnPregunta_Click);
            // 
            // frmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRespuesta);
            this.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red Semántica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExplicacion;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
    }
}

