namespace Viajero_P2
{
    partial class Form1
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
            this.pctbMapa = new System.Windows.Forms.PictureBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsbRutas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMapa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctbMapa
            // 
            this.pctbMapa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctbMapa.Location = new System.Drawing.Point(0, 0);
            this.pctbMapa.Name = "pctbMapa";
            this.pctbMapa.Size = new System.Drawing.Size(573, 469);
            this.pctbMapa.TabIndex = 0;
            this.pctbMapa.TabStop = false;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(85, 22);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(64, 18);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(5, 50);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(219, 20);
            this.txtOrigen.TabIndex = 2;
            this.txtOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(5, 133);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(219, 20);
            this.txtDestino.TabIndex = 4;
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(85, 105);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(71, 18);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(28, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 37);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Encontrar Ruta";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDestino);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblOrigen);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.txtOrigen);
            this.panel1.Location = new System.Drawing.Point(583, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 223);
            this.panel1.TabIndex = 6;
            // 
            // lsbRutas
            // 
            this.lsbRutas.BackColor = System.Drawing.SystemColors.Control;
            this.lsbRutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbRutas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbRutas.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbRutas.FormattingEnabled = true;
            this.lsbRutas.ItemHeight = 20;
            this.lsbRutas.Location = new System.Drawing.Point(573, 249);
            this.lsbRutas.Name = "lsbRutas";
            this.lsbRutas.Size = new System.Drawing.Size(249, 220);
            this.lsbRutas.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 469);
            this.Controls.Add(this.lsbRutas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctbMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajero";
            ((System.ComponentModel.ISupportInitialize)(this.pctbMapa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbMapa;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lsbRutas;
    }
}

